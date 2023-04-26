using AutoMapper;
using DeputadorService.Dtos;
using DeputadorService.Models;

namespace DeputadorService.Profiles;

public class DeputadosProfile : Profile
{
    public DeputadosProfile()
    {
        //source -> target
        CreateMap<Deputado, DeputadoReadDto>().ForMember(d => d.TotalDespesas, opt => opt.MapFrom(m => m.GastosAgregados.TotalDocumentos));
    }
}