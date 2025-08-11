using DataAccess.Data;
using Entities.Models;
using DataAccess.Repositories.Interfaces;
using SmartUniversity.Repositories;

namespace DataAccess.Repositories.Implementations
{
    public class TaskSubmissionRepository : GenericRepository<TaskSubmission>, ITaskSubmissionRepository
    {
        public TaskSubmissionRepository(ApplicationDbContext context) : base(context) { }
    }
}
