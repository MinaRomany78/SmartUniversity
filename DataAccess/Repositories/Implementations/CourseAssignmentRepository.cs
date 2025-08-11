using DataAccess.Data;
using Entities.Models;
using DataAccess.Repositories.Interfaces;
using SmartUniversity.Repositories;

namespace DataAccess.Repositories.Implementations
{
    public class CourseAssignmentRepository : GenericRepository<CourseAssignment>, ICourseAssignmentRepository
    {
        public CourseAssignmentRepository(ApplicationDbContext context) : base(context) { }
    }
}
