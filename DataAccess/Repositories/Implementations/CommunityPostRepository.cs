using DataAccess.Data;
using Entities.Models;
using DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using SmartUniversity.Repositories;

namespace DataAccess.Repositories.Implementations
{
    public class CommunityPostRepository : GenericRepository<CommunityPost>, ICommunityPostRepository
    {
        public CommunityPostRepository(ApplicationDbContext context) : base(context) { }
    }
}
