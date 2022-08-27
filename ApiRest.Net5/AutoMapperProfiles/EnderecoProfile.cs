using ApiRest.Net5.Data.Dtos;
using ApiRest.Net5.Models;
using AutoMapper;

namespace ApiRest.Net5.AutoMapperProfiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<Endereco, ReadEnderecoDto>();
            CreateMap<UpdateEnderecoDto, Endereco>();
        }
    }
}
