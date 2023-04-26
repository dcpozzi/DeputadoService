using DeputadorService.Models;
using Microsoft.EntityFrameworkCore;

namespace DeputadorService.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
    {

    }

    public DbSet<Deputado> Deputados { get; set; }
    public DbSet<DeputadoGastosAgregados> DeputadoGastosAgregados { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DeputadoGastosAgregados>(entity =>
        {
            entity.ToTable("deputado_gastos_agregados", "public");
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<Deputado>()
            .HasOne(d => d.GastosAgregados)
            .WithOne(dga => dga.Deputado)
            .HasForeignKey<DeputadoGastosAgregados>(dga => dga.Id)
            .HasPrincipalKey<Deputado>(d => d.Id);
    }
}