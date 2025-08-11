using DataAccess.Data;
using Entities.Models;
using DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using SmartUniversity.Repositories;

namespace DataAccess.Repositories.Implementations
{
    public class UniversityCourseRepository : GenericRepository<UniversityCourse>, IUniversityCourseRepository
    {
        public UniversityCourseRepository(ApplicationDbContext context) : base(context) { }

        public async Task<UniversityCourse?> GetWithDetailsAsync(int id)
        {
            return await _context.UniversityCourses
                .Include(c => c.Materials)
                .Include(c => c.Tasks)
                .Include(c => c.CourseAssignments)
                .Include(c => c.CourseAssistants)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
