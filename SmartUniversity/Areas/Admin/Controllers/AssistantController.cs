﻿using DataAccess.Repositories.IRepositories;
using Entities.Models;
using Entities.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq.Expressions;
using System.Numerics;
using System.Threading.Tasks;
using Utility.DBInitializer;

namespace SmartUniversity.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AssistantController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public AssistantController(IUnitOfWork unitOfWork, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index(int page = 1)
        {
            var assistants = await _unitOfWork.Assistants.GetAsync(include: new Expression<Func<Assistant, object>>[]
                { 
                    e => e.ApplicationUser,
                });

            if (assistants is null)
                return NotFound();

            var totalAssistantsInPage = 15;
            var totalPages = Math.Ceiling((double)assistants.Count() / totalAssistantsInPage);

            if (page > totalPages && totalPages != 0)
                return View();

            assistants = assistants
                .Skip((page - 1) * (int)totalAssistantsInPage)
                .Take((int)totalAssistantsInPage);

            ViewBag.totalPages = totalPages;
            ViewBag.CurrentPage = page;

            return View(assistants);
        }

        public async Task<IActionResult> Create()
        {
            var vm = new AdminAssistantVM
            {
                CoursesList = (await _unitOfWork.CourseAssistants.GetAsync(
                    include: new Expression<Func<CourseAssistant, object>>[] { e => e.UniversityCourse }))
                .Select(e => new SelectListItem
                {
                    Value = e.Id.ToString(),
                    Text = e.UniversityCourse.Name
                }).ToList()
            };

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AdminAssistantVM vm)
        {
            if (!ModelState.IsValid)
            {
                vm.CoursesList = (await _unitOfWork.CourseAssistants.GetAsync(
                    include: new Expression<Func<CourseAssistant, object>>[] { e => e.UniversityCourse }))
                .Select(e => new SelectListItem
                {
                    Value = e.Id.ToString(),
                    Text = e.UniversityCourse.Name
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

            if (!await _roleManager.RoleExistsAsync(SD.Assistant))
                await _roleManager.CreateAsync(new IdentityRole(SD.Assistant));

            await _userManager.AddToRoleAsync(user, SD.Assistant);

            var assistant = new Assistant
            {
                ApplicationUserId = user.Id
            };

            foreach (var courseId in vm.SelectedCourseIds)
            {
                assistant.CourseAssistants.Add(new CourseAssistant
                {
                    UniversityCourseID = courseId
                });
            }

            await _unitOfWork.Assistants.CreateAsync(assistant);
            await _unitOfWork.Assistants.CommitAsync();

            TempData["success-notification"] = "Assistant created successfully.";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var assistant = await _unitOfWork.Assistants.GetOneAsync(e => e.Id == id,
                 include: new Expression<Func<Assistant, object>>[]
                 {
                     e => e.ApplicationUser,
                     e => e.CourseAssistants
                 });

            if (assistant is null)
                return NotFound();

            var vm = new AdminAssistantVM
            {
                Id = assistant.Id,
                FirstName = assistant.ApplicationUser.FirstName,
                LastName = assistant.ApplicationUser.LastName,
                FullName = assistant.ApplicationUser.FullName,
                Email = assistant!.ApplicationUser.Email ?? "",
                IsEmailConfirmed = assistant.ApplicationUser.EmailConfirmed,
                Address = assistant.ApplicationUser.Address,
                UserName = assistant!.ApplicationUser.UserName ?? "",
                SelectedCourseIds = assistant.CourseAssistants.Select(e => e.UniversityCourseID).ToList(),
                CoursesList = (await _unitOfWork.CourseAssignments.GetAsync(
                    include: new Expression<Func<CourseAssignment, object>>[] { e => e.UniversityCourse }))
                .Select(e => new SelectListItem
                {
                    Value = e.Id.ToString(),
                    Text = e.UniversityCourse.Name
                }).ToList()
            };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AdminAssistantVM vm)
        {
            if (!ModelState.IsValid)
            {
                vm.CoursesList = (await _unitOfWork.CourseAssignments.GetAsync(
                    include: new Expression<Func<CourseAssignment, object>>[] { e => e.UniversityCourse }))
                .Select(e => new SelectListItem
                {
                    Value = e.Id.ToString(),
                    Text = e.UniversityCourse.Name
                }).ToList();

                return View(vm);
            }

            var assistant = await _unitOfWork.Assistants.GetOneAsync(e => e.Id == vm.Id,
                include: new Expression<Func<Assistant, object>>[]
                {
                    e => e.ApplicationUser,
                    e => e.CourseAssistants
                });

            if (assistant is null)
                return NotFound();

            assistant.ApplicationUser.FirstName = vm.FirstName;
            assistant.ApplicationUser.LastName = vm.LastName;
            assistant.ApplicationUser.FullName = vm.FullName;
            assistant.ApplicationUser.Email = vm.Email;
            assistant.ApplicationUser.Address = vm.Address;
            assistant.ApplicationUser.UserName = vm.UserName;
            assistant.ApplicationUser.EmailConfirmed = vm.IsEmailConfirmed;

            assistant.CourseAssistants.Clear();
            if (vm.SelectedCourseIds is not null && vm.SelectedCourseIds.Any())
            {
                foreach (var courseId in vm.SelectedCourseIds)
                    assistant.CourseAssistants.Add(new CourseAssistant{ UniversityCourseID = courseId, AssistantID = assistant.Id});
            }

            await _unitOfWork.Assistants.UpdateAsync(assistant);
            await _unitOfWork.Assistants.CommitAsync();

            TempData["success-notification"] = "Assistant updated successfully";

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var assistant = await _unitOfWork.Assistants.GetOneAsync(e => e.Id == id);

            if (assistant is not null)
            {
                await _unitOfWork.Assistants.DeleteAsync(assistant);

                TempData["success-notification"] = "Assistant Data Deleted Successfully";

                return RedirectToAction(nameof(Index));
            }

            return NotFound();
        }
    }
}
