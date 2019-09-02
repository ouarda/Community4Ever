using Microsoft.EntityFrameworkCore;

namespace Community4Ever.Models
{
    
    public class C4EDbContext : DbContext
    {
        public C4EDbContext(DbContextOptions<C4EDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}