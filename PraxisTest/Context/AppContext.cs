using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using PraxisTest.Models;

namespace PraxisTest.Context
{
    public class AppContext: DbContext
    {
        public AppContext(DbContextOptions<AppContext> options): base(options)
        {
            
        }

        public DbSet<Story> Storys { get; set; }
    }
}
