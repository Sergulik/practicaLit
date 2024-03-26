using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace p2.clasese
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring (DbContextOptionsBuilder optionalBuilder)
        {
            optionalBuilder.UseSqlServer("Data sourse=(localdb)\\MSSQLLocalDB; LazyInitializer Catalog = UsersDb;" );
        }
    }
}
