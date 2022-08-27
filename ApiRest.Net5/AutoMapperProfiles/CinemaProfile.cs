using ApiRest.Net5.Data.Dtos;
using ApiRest.Net5.Models;
using AutoMapper;

namespace ApiRest.Net5.AutoMapperProfiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>();
            CreateMap<UpdateCinemaDto, Cinema>();
        }
    }
}
