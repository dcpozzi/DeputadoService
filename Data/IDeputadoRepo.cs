using DeputadoService.Models;

namespace DeputadoService.Data;

public interface IDeputadoRepo
{
    IEnumerable<DeputadoEstatisticas> GetAllDeputadosEstatisticas();
}