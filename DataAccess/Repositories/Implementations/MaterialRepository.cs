using DataAccess.Data;
using Entities.Models;
using DataAccess.Repositories.Interfaces;
using SmartUniversity.Repositories;

namespace DataAccess.Repositories.Implementations
{
    public class MaterialRepository : GenericRepository<Material>, IMaterialRepository
    {
        public MaterialRepository(ApplicationDbContext context) : base(context) { }
    }
}
