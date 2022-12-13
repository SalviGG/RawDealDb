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
            CreateMap<CardModel,CardDto>();
            CreateMap<CardPropertyModel, CardPropertyDto>();
        }
    }
}
