using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DeputadoService.Models;

public class DeputadosProposicoes
{
    public int IdDeputado { get; set; }
    public Deputado Deputado { get; set; } = new();
    public int IdProposicao { get; set; }
    public Proposicao Proposicao { get; set; } = new();
}
