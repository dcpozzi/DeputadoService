using Microsoft.EntityFrameworkCore;
using DeputadoService.Models;

namespace DeputadoService.Data;

public class DeputadoRepo : IDeputadoRepo
{
    private readonly AppDbContext _context;

    public DeputadoRepo(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<DeputadoEstatisticas> GetAllDeputadosEstatisticas()
    {
        return _context.DeputadosEstatisticas.ToList();
    }
}