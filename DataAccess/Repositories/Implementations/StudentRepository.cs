using DataAccess.Data;
using Entities.Models;
using DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using SmartUniversity.Repositories;

namespace DataAccess.Repositories.Implementations
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext context) : base(context) { }

        public async Task<Student?> GetByNationalIdAsync(string nationalId)
        {
            return await _context.Students
                .Include(s => s.Enrollments)
                .FirstOrDefaultAsync(s => s.NationalID == nationalId);
        }
    }
}
