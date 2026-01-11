using AutoMapper;
using DtoLayer.AboutDto;
using SignalR.EntitiyLayer.Entities;

namespace WebApi.Mapping;

public class AboutMapping:Profile
{
    public AboutMapping()
    {
        CreateMap<About,ResultAboutDto>().ReverseMap();
        CreateMap<About, CreateAboutDto>().ReverseMap();
        CreateMap<About, UpdateAboutDto>().ReverseMap();
        CreateMap<About,GetAboutDto>().ReverseMap();
    }
}
