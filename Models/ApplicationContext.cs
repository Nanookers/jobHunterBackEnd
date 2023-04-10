using Microsoft.EntityFrameworkCore;

namespace jobHunterBackEnd.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {}
        // public DbSet<MyClass> MyClassTable { get; set; }

        public DbSet<Application> Applications { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}