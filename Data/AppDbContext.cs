using DeputadoService.Models;
using Microsoft.EntityFrameworkCore;

namespace DeputadoService.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
    {

    }
    public DbSet<DeputadoEstatisticas> DeputadosEstatisticas { get; set; }
}