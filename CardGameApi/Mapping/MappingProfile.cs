using AutoMapper;
using Entites.Models;
using SharedDtos.DataTransferObjects;

namespace CardGameApi.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Card, CardDto>();
                //.ForCtorParam("Suit", opt => opt.MapFrom(x => x.Suit.ToString()))
                //.ForCtorParam("Number", opt => opt.MapFrom(x => Convert.ToInt32(x.Number)));
            CreateMap<HandHistory, HandHistoryDto>();
            CreateMap<HandHistoryDto, HandHistory>();
        }
    }
}
