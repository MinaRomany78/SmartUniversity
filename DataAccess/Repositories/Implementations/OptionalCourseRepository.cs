using DataAccess.Data;
using Entities.Models;
using DataAccess.Repositories.Interfaces;
using SmartUniversity.Repositories;

namespace DataAccess.Repositories.Implementations
{
    public class OptionalCourseRepository : GenericRepository<OptionalCourse>, IOptionalCourseRepository
    {
        public OptionalCourseRepository(ApplicationDbContext context) : base(context) { }
    }
}
