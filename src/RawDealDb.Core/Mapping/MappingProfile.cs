using AutoMapper;
using RawDealDb.Core.DTO;
using RawDealDb.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDealDb.Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<SetWithCardsModel, SetWithCardsDto>();
            CreateMap<SetWithoutCardsModel, SetWithoutCardsDto>();
            CreateMap<CardModel,CardDto>()
                .ForMember(dest => dest.Format, opt => opt.MapFrom(src => src.Properties.FirstOrDefault(x => x.Property == "Format").Value))
                .ForMember(dest => dest.Traits, opt => opt.MapFrom(src => src.Properties.FirstOrDefault(x => x.Property == "Traits").Value))
                .ForMember(dest => dest.CardText, opt => opt.MapFrom(src => src.Properties.FirstOrDefault(x => x.Property == "Card Text").Value));
            CreateMap<CardPropertyModel, CardPropertyDto>();
        }
    }
}
