using API_REST_The_Last_Of_Us.Src.Models.Dto;
using API_REST_The_Last_Of_Us.Src.Models.Entity;
using AutoMapper;

namespace API_REST_The_Last_Of_Us.Src.Models.Profiles
{
  public class SobreProfile : Profile
  {
    public SobreProfile()
    {
      CreateMap<SobreResponseDto, SobreModel>();
    }
  }
}
