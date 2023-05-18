using AutoMapper;
using DeputadoService.Dtos;
using DeputadoService.Models;

namespace DeputadoService.Profiles;

public class DeputadosProfile : Profile
{
    public DeputadosProfile()
    {
        //source -> target
        CreateMap<DeputadoEstatisticas, DeputadoReadDto>();
    }
}