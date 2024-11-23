using Hub.Models;
using Microsoft.EntityFrameworkCore;

namespace Hub.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }
        public DbSet<Company> companies { get; set; }
    }
}
