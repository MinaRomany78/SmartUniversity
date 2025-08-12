using DataAccess.Data;
using Entities.Models;
using DataAccess.Repositories.IRepositories;

namespace DataAccess.Repositories
{
    public class OptionalCourseEnrollmentRepository : Repository<OptionalCourseEnrollment>, IOptionalCourseEnrollmentRepository
    {
        private readonly ApplicationDbContext _context;
        public OptionalCourseEnrollmentRepository(ApplicationDbContext context) : base(context) { 
            _context = context;
        }
    }
}
