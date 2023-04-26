using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeputadorService.Models;

public class Deputado
{
    [Key]
    [Required]
    public int Id { get; set; }
    public int? IdDeputadoAPI { get; set; }
    public int? IdDeputadoArq { get; set; }
    [Required]
    public string Nome { get; set; } = string.Empty;

    public DeputadoGastosAgregados? GastosAgregados { get; set; }
}