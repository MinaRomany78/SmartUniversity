

namespace DataAccess.Repositories.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        IApplicationRepository Applications { get; }
        IApplicationUserRepository ApplicationUsers { get; }
        IAssistantRepository Assistants { get; }
        ICommentRepository Comments { get; }
        ICommunityPostRepository CommunityPosts { get; }
        ICourseAssignmentRepository CourseAssignments { get; }
        ICourseAssistantRepository CourseAssistants { get; }
        IDoctorRepository Doctors { get; }
        IEnrollmentRepository Enrollments { get; }
        IFeedbackRepository Feedbacks { get; }
        IMaterialRepository Materials { get; }
        IOptionalCourseRepository OptionalCourses { get; }
        IOptionalCourseEnrollmentRepository OptionalCourseEnrollments { get; }
        IPromoCodeRepository PromoCodes { get; }
        IStudentRepository Students { get; }
        ISubjectTaskRepository SubjectTasks { get; }
        ISupportTicketRepository SupportTickets { get; }
        ITaskSubmissionRepository TaskSubmissions { get; }
        IUniversityCourseRepository UniversityCourses { get; }
        IApplicationUserOtpRepository ApplicationUserOtps {  get; }

        Task<int> CompleteAsync();
    }
}
