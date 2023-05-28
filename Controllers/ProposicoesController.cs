using AutoMapper;
using DeputadoService.Data;
using DeputadoService.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace DeputadoService.Controllers;

[Route("api/deputados/{idDeputado}/Proposicoes")]
[ApiController]
public class ProposicoesController : ControllerBase
{
    private readonly IProposicaoRepo _repo;
    private readonly IMapper _mapper;

    public ProposicoesController(IProposicaoRepo repo, IMapper mapper)
    {
        this._repo = repo;
        this._mapper = mapper;
    }

    [HttpGet]
    public ActionResult<IEnumerable<ProposicaoReadDto>> GetProposicoes(int idDeputado)
    {
        var proposicoesItem = _repo.GetAllProposicoesByDeputado(idDeputado);
        return Ok(_mapper.Map<IEnumerable<ProposicaoReadDto>>(proposicoesItem));
    }

}