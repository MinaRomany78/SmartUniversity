using DataAccess.Data;
using Entities.Models;
using DataAccess.Repositories.IRepositories;

namespace DataAccess.Repositories
{
    public class CourseAssistantRepository : Repository<CourseAssistant>, ICourseAssistantRepository
    {
        private readonly ApplicationDbContext _context;
        public CourseAssistantRepository(ApplicationDbContext context) : base(context) {
        _context = context;
        }
    }
}
