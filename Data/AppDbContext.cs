using DeputadoService.Models;
using Microsoft.EntityFrameworkCore;

namespace DeputadoService.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
    {

    }
    public DbSet<Deputado> Deputados { get; set; }
    public DbSet<DeputadoEstatisticas> DeputadosEstatisticas { get; set; }
    public DbSet<Proposicao> Proposicoes { get; set; }
    public DbSet<DeputadosProposicoes> DeputadosProposicoes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DeputadosProposicoes>().HasKey(dp => new { dp.IdDeputado, dp.IdProposicao });
        modelBuilder.Entity<DeputadosProposicoes>().HasOne(p => p.Proposicao)
        .WithMany(p => p.DeputadosProposicoes)
        .HasForeignKey(p => p.IdProposicao)
        .HasPrincipalKey(p => p.IdProposicao);
    }
}