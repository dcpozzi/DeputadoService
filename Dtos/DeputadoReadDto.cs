namespace DeputadorService.Dtos;

public class DeputadoReadDto
{
    public int Id { get; set; }
    public int IdDeputadoAPI { get; set; }
    public int IdDeputadoArq { get; set; }
    public string Nome { get; set; } = string.Empty;
    public double TotalDespesas { get; set; } = 0;
}