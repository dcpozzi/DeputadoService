using DeputadorService.Models;

namespace DeputadorService.Data;

public interface IDeputadoRepo
{
    IEnumerable<Deputado> GetAllDeputados();

    Deputado GetDeputadoById(int id);
}