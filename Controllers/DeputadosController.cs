using AutoMapper;
using DeputadorService.Data;
using DeputadorService.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace DeputadorService.Controllers;

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
    public ActionResult<IEnumerable<DeputadoReadDto>> GetDeputados()
    {
        var deputadosItem = _repo.GetAllDeputados();
        return Ok(_mapper.Map<IEnumerable<DeputadoReadDto>>(deputadosItem));
    }
}