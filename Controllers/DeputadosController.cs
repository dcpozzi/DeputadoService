using AutoMapper;
using DeputadoService.Data;
using DeputadoService.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace DeputadoService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DeputadosController : ControllerBase
{
    private readonly IDeputadoRepo _repo;
    private readonly IMapper _mapper;

    public DeputadosController(IDeputadoRepo repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    [HttpGet]
    [Route("statistics")]
    public ActionResult<IEnumerable<DeputadoEstatisticasReadDto>> GetDeputadosEstatisticas()
    {
        var deputadosItem = _repo.GetAllDeputadosEstatisticas();
        return Ok(_mapper.Map<IEnumerable<DeputadoEstatisticasReadDto>>(deputadosItem));
    }
}