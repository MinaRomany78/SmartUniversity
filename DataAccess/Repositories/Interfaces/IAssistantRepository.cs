using Entities.Models;

namespace SmartUniversity.Repositories.Interfaces
{
    public interface IAssistantRepository : IGenericRepository<Assistant>
    {
        Task<Assistant?> GetAssistantWithCoursesAsync(int id);
    }
}
