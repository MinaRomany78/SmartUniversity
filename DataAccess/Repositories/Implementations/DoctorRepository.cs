using DataAccess.Data;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using SmartUniversity.Repositories.Interfaces;

namespace SmartUniversity.Repositories.Implementations
{
    public class DoctorRepository : GenericRepository<Doctor>, IDoctorRepository
    {
        public DoctorRepository(ApplicationDbContext context) : base(context) { }

        public async Task<Doctor?> GetDoctorWithCoursesAsync(int id)
        {
            return await _context.Doctors
                .Include(d => d.Courses)
                .FirstOrDefaultAsync(d => d.Id == id);
        }
    }
}
