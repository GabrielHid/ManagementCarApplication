using System.Data.Entity;

namespace ManagementCarApplication.Models
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext() : base("DefaultConnection")
        {

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public DbSet<Carro> Carros { get; set; }
        public DbSet<Marca> Marcas { get; set; }

    }
}