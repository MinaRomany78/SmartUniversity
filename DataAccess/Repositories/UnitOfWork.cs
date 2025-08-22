using DataAccess.Data;
using DataAccess.Repositories.IRepositories;


namespace DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IApplicationRepository Applications { get; }
        public IApplicationUserRepository ApplicationUsers { get; }
        public IAssistantRepository Assistants { get; }
        public ICommentRepository Comments { get; }
        public ICommunityPostRepository CommunityPosts { get; }
        //public ICourseAssignmentRepository CourseAssignments { get; }
        //public ICourseAssistantRepository CourseAssistants { get; }
        public IAssistantCourseRepository AssistantCourses { get; }
        public IDoctorAssistantRepository DoctorAssistants { get; }
        public IDoctorRepository Doctors { get; }
        public IEnrollmentRepository Enrollments { get; }
        public IFeedbackRepository Feedbacks { get; }
        public IMaterialRepository Materials { get; }
        public IOptionalCourseRepository OptionalCourses { get; }
        public IOptionalCourseEnrollmentRepository OptionalCourseEnrollments { get; }
        public IPromoCodeRepository PromoCodes { get; }
        public IStudentRepository Students { get; }
        public ISubjectTaskRepository SubjectTasks { get; }
        public ISupportTicketRepository SupportTickets { get; }
        public ITaskSubmissionRepository TaskSubmissions { get; }
        public IUniversityCourseRepository UniversityCourses { get; }
        public IApplicationUserOtpRepository ApplicationUserOtps {  get; }
        public IDepartmentRepository Departments {  get; }
        public ITermRepository Terms { get; }

        public UnitOfWork(
            ApplicationDbContext context,
            IDepartmentRepository departments,
            IApplicationRepository applications,
            IApplicationUserOtpRepository  applicationUserOtps,
            IApplicationUserRepository applicationUsers,
            IAssistantRepository assistants,
            ICommentRepository comments,
            ICommunityPostRepository communityPosts,
            //ICourseAssignmentRepository courseAssignments,
            //ICourseAssistantRepository courseAssistants,
            IAssistantCourseRepository assistantCourses,
            IDoctorAssistantRepository doctorAssistants,
            IDoctorRepository doctors,
            IEnrollmentRepository enrollments,
            IFeedbackRepository feedbacks,
            IMaterialRepository materials,
            IOptionalCourseRepository optionalCourses,
            IOptionalCourseEnrollmentRepository optionalCourseEnrollments,
            IPromoCodeRepository promoCodes,
            IStudentRepository students,
            ISubjectTaskRepository subjectTasks,
            ISupportTicketRepository supportTickets,
            ITaskSubmissionRepository taskSubmissions,
            IUniversityCourseRepository universityCourses,
            ITermRepository terms 
            )
        {
            _context = context;
            Applications = applications;
            ApplicationUsers = applicationUsers;
            Assistants = assistants;
            Comments = comments;
            CommunityPosts = communityPosts;
            //CourseAssignments = courseAssignments;
            //CourseAssistants = courseAssistants;
            AssistantCourses = assistantCourses;
            DoctorAssistants = doctorAssistants;
            Doctors = doctors;
            Enrollments = enrollments;
            Feedbacks = feedbacks;
            Materials = materials;
            OptionalCourses = optionalCourses;
            OptionalCourseEnrollments = optionalCourseEnrollments;
            PromoCodes = promoCodes;
            Students = students;
            SubjectTasks = subjectTasks;
            SupportTickets = supportTickets;
            TaskSubmissions = taskSubmissions;
            UniversityCourses = universityCourses;
            ApplicationUserOtps = applicationUserOtps;
            Departments = departments;
            Terms = terms;
        }

        public async Task<int> CompleteAsync() => await _context.SaveChangesAsync();

        public void Dispose() => _context.Dispose();
    }
}
