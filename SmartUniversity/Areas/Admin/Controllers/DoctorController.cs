using DataAccess.Repositories.IRepositories;
using Entities.Models;
using Entities.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Utility.DBInitializer;

namespace SmartUniversity.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DoctorController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public DoctorController(IUnitOfWork unitOfWork, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index(int page = 1)
        {
            var doctors = await _unitOfWork.Doctors.GetAsync(include: new Expression<Func<Doctor, object>>[]
            {
                e => e.ApplicationUser
            });

            if (doctors is null)
                return NotFound();

            var totalDoctorsInPage = 15;
            var totalPages = Math.Ceiling((double)doctors.Count() / totalDoctorsInPage);

            if (page > totalPages && totalPages != 0)
                return View(); ;

            doctors = doctors
                .Skip((page - 1) * (int)totalDoctorsInPage)
                .Take((int)totalDoctorsInPage);

            ViewBag.totalPages = totalPages;
            ViewBag.CurrentPage = page;


            return View(doctors);
        }

        public async Task<IActionResult> Create()
        {
            var vm = new AdminDoctorVM
            {
                AssistantsList = (await _unitOfWork.Assistants.GetAsync(
                    include: new Expression<Func<Assistant, object>>[] { e => e.ApplicationUser }))
                .Select(e => new SelectListItem
                {
                    Value = e.Id.ToString(),
                    Text = e.ApplicationUser.FullName
                }).ToList(),

                CoursesList = (await _unitOfWork.UniversityCourses.GetAsync(
                    include: new Expression<Func<UniversityCourse, object>>[] {}))
                .Select(e => new SelectListItem
                {
                    Value = e.Id.ToString(),
                    Text = e.Name
                }).ToList()
            };

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AdminDoctorVM vm)
        {
            if (!ModelState.IsValid)
            {
                vm.AssistantsList = (await _unitOfWork.Assistants.GetAsync(
                    include: new Expression<Func<Assistant, object>>[] { e => e.ApplicationUser }))
                .Select(e => new SelectListItem
                {
                    Value = e.Id.ToString(),
                    Text = e.ApplicationUser.FullName
                }).ToList();

                vm.CoursesList = (await _unitOfWork.UniversityCourses.GetAsync())
                .Select(e => new SelectListItem
                {
                    Value = e.Id.ToString(),
                    Text = e.Name
                }).ToList();

                return View(vm);
            }


            var user = new ApplicationUser
            {
                FirstName = vm.FirstName,
                LastName = vm.LastName,
                FullName = vm.FullName,
                Email = vm.Email,
                UserName = vm.UserName,
                Address = vm.Address,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(user, vm.Password!);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                    ModelState.AddModelError("", error.Description);

                return View(vm);
            }

            if (!await _roleManager.RoleExistsAsync(SD.Doctor))
                await _roleManager.CreateAsync(new IdentityRole(SD.Doctor));

            await _userManager.AddToRoleAsync(user, SD.Doctor);

            var doctor = new Doctor
            {
                ApplicationUserId = user.Id
            };


            foreach (var assistantId in vm.SelectedAssistantIds)
            {
                foreach (var courseId in vm.SelectedCourseIds)
                {
                    var isAssistantAssignedToCourse = (await _unitOfWork.AssistantCourses
                        .GetAsync(e => e.AssistantId == assistantId && e.CourseId == courseId)).Any();

                    if (!isAssistantAssignedToCourse)
                    {
                        ModelState.AddModelError("", $"Assistant {assistantId} is not assigned to Course {courseId}");
                        return View(vm);
                    }

                    doctor.DoctorAssistants.Add(new DoctorAssistant
                    {
                        AssistantId = assistantId,
                        CourseId = courseId,
                        Doctor = doctor
                    });
                }
            }

            foreach (var courseId in vm.SelectedCourseIds)
            {
                var course = await _unitOfWork.UniversityCourses.GetOneAsync(e => e.Id == courseId);
                if (course is not null)
                    doctor.UniversityCourses.Add(course);
            }

            await _unitOfWork.Doctors.CreateAsync(doctor);
            await _unitOfWork.Doctors.CommitAsync();
            TempData["success-notification"] = "Doctor created successfully.";

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var doctor = await _unitOfWork.Doctors.GetOneAsync(e => e.Id == id,
                include: new Expression<Func<Doctor, object>>[]
                {
                    e => e.ApplicationUser,
                    e => e.DoctorAssistants,
                    e => e.UniversityCourses
                });

            if (doctor is null)
                return NotFound();

            var vm = new AdminDoctorVM
            {
                Id = doctor.Id,
                FirstName = doctor.ApplicationUser.FirstName,
                LastName = doctor.ApplicationUser.LastName,
                FullName = doctor.ApplicationUser.FullName,
                Email = doctor!.ApplicationUser.Email ?? "",
                IsEmailConfirmed = doctor.ApplicationUser.EmailConfirmed,
                Address = doctor.ApplicationUser.Address,
                UserName = doctor!.ApplicationUser.UserName ?? "",
                SelectedAssistantIds = doctor.DoctorAssistants.Select(e => e.AssistantId).ToList(),
                SelectedCourseIds = doctor.UniversityCourses.Select(e => e.Id).ToList(),
                AssistantsList = (await _unitOfWork.Assistants.GetAsync(
                    include: new Expression<Func<Assistant, object>>[] { e => e.ApplicationUser }))
                .Select(e => new SelectListItem
                {
                    Value = e.Id.ToString(),
                    Text = e.ApplicationUser.FullName
                }).ToList(),
                CoursesList = (await _unitOfWork.UniversityCourses.GetAsync())
                .Select(e => new SelectListItem
                {
                    Value = e.Id.ToString(),
                    Text = e.Name
                }).ToList()
            };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AdminDoctorVM vm)
        {
            if (!ModelState.IsValid)
            {
                vm.AssistantsList = (await _unitOfWork.Assistants.GetAsync(
                    include: new Expression<Func<Assistant, object>>[] { e => e.ApplicationUser }))
                .Select(e => new SelectListItem
                {
                    Value = e.Id.ToString(),
                    Text = e.ApplicationUser.FullName
                }).ToList();

                vm.CoursesList = (await _unitOfWork.UniversityCourses.GetAsync())
                .Select(e => new SelectListItem
                {
                    Value = e.Id.ToString(),
                    Text = e.Name
                }).ToList();

                return View(vm);
            }

            var doctor = await _unitOfWork.Doctors.GetOneAsync(e => e.Id == vm.Id,
                include: new Expression<Func<Doctor, object>>[]
                {
                    e => e.ApplicationUser,
                });

            if (doctor is null)
                return NotFound();

            doctor.ApplicationUser.FirstName = vm.FirstName;
            doctor.ApplicationUser.LastName = vm.LastName;
            doctor.ApplicationUser.FullName = vm.FullName;
            doctor.ApplicationUser.Email = vm.Email;
            doctor.ApplicationUser.Address = vm.Address;
            doctor.ApplicationUser.UserName = vm.UserName;
            doctor.ApplicationUser.EmailConfirmed = vm.IsEmailConfirmed;

            doctor.DoctorAssistants.Clear();
            if (vm.SelectedAssistantIds != null && vm.SelectedAssistantIds.Any()
                && vm.SelectedCourseIds != null && vm.SelectedCourseIds.Any())
            {
                var uniquePairs = vm.SelectedAssistantIds
                    .SelectMany(aid => vm.SelectedCourseIds.Select(cid => new { AssistantId = aid, CourseId = cid }))
                    .Distinct();

                foreach (var pair in uniquePairs)
                {
                    var isAssistantAssignedToCourse = (await _unitOfWork.AssistantCourses
                          .GetAsync(e => e.AssistantId == pair.AssistantId && e.CourseId == pair.CourseId)).Any();

                    if (!isAssistantAssignedToCourse)
                    {
                            ModelState.AddModelError("", $"Assistant {pair.AssistantId} is not assigned to Course {pair.CourseId}");
                            return View(vm);
                    }

                    doctor.DoctorAssistants.Add(new DoctorAssistant
                    {
                        AssistantId = pair.AssistantId,
                        CourseId = pair.CourseId,
                        DoctorId = doctor.Id
                    });
                }
            }

            doctor.UniversityCourses.Clear();
            if (vm.SelectedCourseIds != null && vm.SelectedCourseIds.Any())
            {
                foreach (var courseId in vm.SelectedCourseIds)
                {
                    var course = await _unitOfWork.UniversityCourses.GetOneAsync(e => e.Id == courseId);
                    if (course is not null)
                        doctor.UniversityCourses.Add(course);
                }
            }

            await _unitOfWork.Doctors.UpdateAsync(doctor);
            await _unitOfWork.Doctors.CommitAsync();

            TempData["success-notification"] = "Doctor updated successfully";

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var doctor = await _unitOfWork.Doctors.GetOneAsync(e => e.Id == id);

            if (doctor is not null)
            {
                await _unitOfWork.Doctors.DeleteAsync(doctor);

                TempData["success-notification"] = "Doctor Data Deleted Successfully";

                return RedirectToAction(nameof(Index));
            }

            return NotFound();
        }
    }
}
