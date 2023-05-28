using DeputadoService.Models;

namespace DeputadoService.Data;

public interface IProposicaoRepo
{
    IEnumerable<Proposicao> GetAllProposicoesByDeputado(int idDeputado);
}