using Microsoft.EntityFrameworkCore;

namespace SegundoParcial_LP2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Proveedor> Proveedores { get; set; }


    }
}
