using Microsoft.EntityFrameworkCore;
using webdev.Models;

namespace webdev.Data
{
    public class ApplicationContext : DbContext

    {
        public DbSet<User> users { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
