using Entities.Models;


namespace DataAccess.Repositories.IRepositories
{
    public interface IUniversityCourseRepository : IRepository<UniversityCourse>
    {
        //Task<UniversityCourse?> GetWithDetailsAsync(int id); // دالة مفيدة لِـ includes
    }
}
