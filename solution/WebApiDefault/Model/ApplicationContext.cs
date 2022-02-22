using Microsoft.EntityFrameworkCore;

namespace WebApiDefault.Model
{
    public class ApplicationContext : DbContext
    {
        public virtual DbSet<Klant> Klanten { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
            
        }
    }
    
}