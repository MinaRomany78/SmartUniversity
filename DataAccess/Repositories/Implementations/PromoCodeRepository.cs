using DataAccess.Data;
using Entities.Models;
using DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using SmartUniversity.Repositories;

namespace DataAccess.Repositories.Implementations
{
    public class PromoCodeRepository : GenericRepository<PromoCode>, IPromoCodeRepository
    {
        public PromoCodeRepository(ApplicationDbContext context) : base(context) { }

        public async Task<PromoCode?> GetByCodeAsync(string code)
        {
            return await _context.PromoCodes
                .Include(p => p.OptionalCourses)
                .FirstOrDefaultAsync(p => p.Code == code);
        }
    }
}
