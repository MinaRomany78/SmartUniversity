using Entities.Models;
using SmartUniversity.Repositories;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interfaces
{
    public interface IUniversityCourseRepository : IGenericRepository<UniversityCourse>
    {
        Task<UniversityCourse?> GetWithDetailsAsync(int id); // دالة مفيدة لِـ includes
    }
}
