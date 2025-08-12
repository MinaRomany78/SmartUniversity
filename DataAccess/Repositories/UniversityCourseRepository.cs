using DataAccess.Data;
using Entities.Models;
using DataAccess.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class UniversityCourseRepository : Repository<UniversityCourse>, IUniversityCourseRepository
    {
        private readonly ApplicationDbContext _context;
        public UniversityCourseRepository(ApplicationDbContext context) : base(context) {
            _context = context;
        }

        //public async Task<UniversityCourse?> GetWithDetailsAsync(int id)
        //{
        //    return await _context.UniversityCourses
        //        .Include(c => c.Materials)
        //        .Include(c => c.Tasks)
        //        .Include(c => c.CourseAssignments)
        //        .Include(c => c.CourseAssistants)
        //        .FirstOrDefaultAsync(c => c.Id == id);
        //}
    }
}
