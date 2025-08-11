using Entities.Models;
using SmartUniversity.Repositories;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interfaces
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        Task<Student?> GetByNationalIdAsync(string nationalId); // واجهة مفيدة للبحث
    }
}
