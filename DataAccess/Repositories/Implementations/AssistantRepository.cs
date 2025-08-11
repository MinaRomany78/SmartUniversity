using DataAccess.Data;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using SmartUniversity.Repositories.Interfaces;

namespace SmartUniversity.Repositories.Implementations
{
    public class AssistantRepository : GenericRepository<Assistant>, IAssistantRepository
    {
        public AssistantRepository(ApplicationDbContext context) : base(context) { }

        public async Task<Assistant?> GetAssistantWithCoursesAsync(int id)
        {
            return await _context.Assistants
                .Include(a => a.Course)
                .FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}
