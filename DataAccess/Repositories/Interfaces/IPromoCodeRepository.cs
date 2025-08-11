using Entities.Models;
using SmartUniversity.Repositories;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interfaces
{
    public interface IPromoCodeRepository : IGenericRepository<PromoCode>
    {
        Task<PromoCode?> GetByCodeAsync(string code); // واجهة مفيدة لـ PromoCode
    }
}
