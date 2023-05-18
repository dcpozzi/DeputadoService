using System.ComponentModel.DataAnnotations;

namespace DeputadoService.Models;
public class DeputadoEstatisticas
{
    [Key]
    public int IdDeputado { get; set; }
    public decimal? TotalDocumentos { get; set; }
    public decimal? TotalGlosas { get; set; }
    public decimal? TotalLiquido { get; set; }
    public int? TotalProposicoes { get; set; }
}