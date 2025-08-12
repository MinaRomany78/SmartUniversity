using DataAccess.Data;
using Entities.Models;
using DataAccess.Repositories.Interfaces;
using SmartUniversity.Repositories;

namespace DataAccess.Repositories.Implementations
{
    public class CourseAssistantRepository : GenericRepository<CourseAssistant>, ICourseAssistantRepository
    {
        public CourseAssistantRepository(ApplicationDbContext context) : base(context) { }
    }
}
