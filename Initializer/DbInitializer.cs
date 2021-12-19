using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingAnniversary.Data;

namespace WeddingAnniversary.Initializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager; 
        
        public DbInitializer(ApplicationDbContext db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            IdentityUser user = _db.Users.Where(u => u.Email == "cfrylinck1997@gmail.com").FirstOrDefault();

            if (user == null)
            {
                _userManager.CreateAsync(new IdentityUser
                {
                    Email = "cfrylinck1997@gmail.com",
                    UserName = "cfrylinck1997@gmail.com",
                    EmailConfirmed = true,
                    NormalizedUserName = "Cornelius Frylinck"
                }, "Cpf2758!").GetAwaiter().GetResult();
            }
        }
    }
}
