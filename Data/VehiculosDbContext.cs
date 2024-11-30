using Microsoft.EntityFrameworkCore;
using VehiculosAPI.Models;

namespace VehiculosAPI.Data
{
    public class VehiculosDbContext : DbContext
    {
        public VehiculosDbContext(DbContextOptions<VehiculosDbContext> options) : base(options) { }

        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<PrecioVehiculo> PreciosVehiculos { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Vehiculo>()
                .Property(v => v.FechaRegistro)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
