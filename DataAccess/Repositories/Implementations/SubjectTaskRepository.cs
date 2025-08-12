using DataAccess.Data;
using Entities.Models;
using DataAccess.Repositories.Interfaces;
using SmartUniversity.Repositories;

namespace DataAccess.Repositories.Implementations
{
    public class SubjectTaskRepository : GenericRepository<SubjectTask>, ISubjectTaskRepository
    {
        public SubjectTaskRepository(ApplicationDbContext context) : base(context) { }
    }
}
