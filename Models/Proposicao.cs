using System.ComponentModel.DataAnnotations;

namespace DeputadoService.Models;
public class Proposicao
{
    [Key]
    public int Id { get; set; }
    public int IdProposicao { get; set; }
    public string Ementa { get; set; } = "";
    public List<DeputadosProposicoes> DeputadosProposicoes { get; set; } = new();
}