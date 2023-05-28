namespace DeputadoService.Dtos;

public class DeputadoEstatisticasReadDto
{
    public int IdDeputado { get; set; }
    public double TotalDocumentos { get; set; } = 0;
    public double TotalProposicoes { get; set; } = 0;
}