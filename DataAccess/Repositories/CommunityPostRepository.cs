using DataAccess.Data;
using Entities.Models;
using DataAccess.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class CommunityPostRepository : Repository<CommunityPost>, ICommunityPostRepository
    {
        private readonly ApplicationDbContext _context;
        public CommunityPostRepository(ApplicationDbContext context) : base(context) { 
            _context = context;
        }
    }
}
