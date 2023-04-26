using System.ComponentModel.DataAnnotations;

namespace DeputadorService.Models;
public class DeputadoGastosAgregados
{
    [Key]
    public int Id { get; set; }
    public decimal? TotalDocumentos { get; set; }
    public decimal? TotalGlosas { get; set; }
    public decimal? TotalLiquido { get; set; }
    public Deputado Deputado { get; set; }
}