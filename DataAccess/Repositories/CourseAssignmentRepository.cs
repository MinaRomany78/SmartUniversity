using DataAccess.Data;
using Entities.Models;
using DataAccess.Repositories.IRepositories;

namespace DataAccess.Repositories
{
    public class CourseAssignmentRepository : Repository<CourseAssignment>, ICourseAssignmentRepository
    {
        private readonly ApplicationDbContext _context;
        public CourseAssignmentRepository(ApplicationDbContext context) : base(context) {
            _context = context;
        }
    }
}
