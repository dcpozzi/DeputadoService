using DeputadoService.Models;

namespace DeputadoService.Data;

public class ProposicaoRepo : IProposicaoRepo
{
    private readonly AppDbContext _context;

    public ProposicaoRepo(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Proposicao> GetAllProposicoesByDeputado(int idDeputado)
    {
        var query = from Proposicao in _context.Proposicoes
                    join DeputadosProposicoes in _context.DeputadosProposicoes on Proposicao.IdProposicao equals DeputadosProposicoes.IdProposicao
                    join Deputado in _context.Deputados on DeputadosProposicoes.IdDeputado equals Deputado.Id
                    where Deputado.IdDeputadoAPI == idDeputado
                    select Proposicao;
        return query.ToList();
    }
}