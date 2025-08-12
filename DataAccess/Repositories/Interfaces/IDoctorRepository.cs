using Entities.Models;

namespace SmartUniversity.Repositories.Interfaces
{
    public interface IDoctorRepository : IGenericRepository<Doctor>
    {
        Task<Doctor?> GetDoctorWithCoursesAsync(int id);
    }
}
