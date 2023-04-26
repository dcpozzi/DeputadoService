using Microsoft.EntityFrameworkCore;
using DeputadorService.Models;

namespace DeputadorService.Data;

public class DeputadoRepo : IDeputadoRepo
{
    private readonly AppDbContext _context;

    public DeputadoRepo(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Deputado> GetAllDeputados()
    {
        return _context.Deputados.Where<Deputado>(d => d.IdDeputadoAPI != null).Include(d => d.GastosAgregados).ToList();
    }

    public Deputado GetDeputadoById(int id)
    {
        return _context.Deputados.FirstOrDefault(d => d.Id == id)!;
    }
}