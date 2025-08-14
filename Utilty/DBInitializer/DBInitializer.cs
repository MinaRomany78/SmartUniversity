using DataAccess.Data;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Utility.DBInitializer;

namespace Utility.DBInitializer
{
    public class DBInitializer : IDBInitializer
    {
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public DBInitializer(
            ApplicationDbContext context,
            RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public void Initialize()
        {
            // Apply pending migrations if any
            if (_context.Database.GetPendingMigrations().Any())
            {
                _context.Database.Migrate();
            }

            // Only create roles and default user if no roles exist
            if (!_roleManager.Roles.Any())
            {
                _roleManager.CreateAsync(new IdentityRole(SD.SuperAdmin)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.Admin)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.Assistant)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.Doctor)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.ExternalStudent)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.UniversityStudent)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.Employee)).GetAwaiter().GetResult();

                // Create Super Admin user
                _userManager.CreateAsync(new ApplicationUser
                {
                    FullName = "Super Admin",
                    UserName = "SuperAdmin",
                    Email = "Superadmin@eraasoft.com",
                    EmailConfirmed = true
                }, "Admin123+").GetAwaiter().GetResult();

                var user = _userManager.FindByNameAsync("SuperAdmin").GetAwaiter().GetResult();
                if (user != null)
                {
                    _userManager.AddToRoleAsync(user, SD.SuperAdmin).GetAwaiter().GetResult();
                }
            }
        }
    }
}
