using Microsoft.EntityFrameworkCore;

namespace WebApiDefault.Model
{
    public class ApplicationContext : DbContext
    {
        public virtual DbSet<Klant> Klanten { get; set; }
        public virtual DbSet<Auto> Autos { get; set; }
        public virtual DbSet<Medewerker> Personeel { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }
    }

}