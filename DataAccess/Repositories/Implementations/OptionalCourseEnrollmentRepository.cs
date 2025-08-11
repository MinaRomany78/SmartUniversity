using DataAccess.Data;
using Entities.Models;
using DataAccess.Repositories.Interfaces;
using SmartUniversity.Repositories;

namespace DataAccess.Repositories.Implementations
{
    public class OptionalCourseEnrollmentRepository : GenericRepository<OptionalCourseEnrollment>, IOptionalCourseEnrollmentRepository
    {
        public OptionalCourseEnrollmentRepository(ApplicationDbContext context) : base(context) { }
    }
}
