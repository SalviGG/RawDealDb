using AutoMapper;
using RawDealDb.Core.DTO;
using RawDealDb.Core.Interfaces.DAL;
using RawDealDb.Core.Interfaces.Service;
using RawDealDb.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDealDb.Core.Service
{
    public class SetServiceCore : ISetServiceCore
    {
        private readonly ISetsRepository _setsRepository;
        private readonly IMapper _mapper;
        public SetServiceCore(ISetsRepository setsRepository, IMapper mapper)
        {
            _setsRepository = setsRepository;
            _mapper = mapper;
        }

        public IEnumerable<SetWithoutCardsDto> GetAllSets(string contextPath)
        {
            var setsModel = _setsRepository.GetAllSets<SetWithoutCardsModel>(contextPath);
            var setList = _mapper.Map<IEnumerable<SetWithoutCardsDto>>(setsModel);
            return setList;
        }

        public SetWithCardsDto GetSetWithCardsById(string setId, string contextPath)
        {
            var setModel = _setsRepository.GetSetById<SetWithCardsModel>(setId, contextPath);
            var set = _mapper.Map<SetWithCardsDto>(setModel);
            return set;
        }

        public SetWithoutCardsDto GetSetWithoutCardsById(string setId, string contextPath)
        {
            var setModel = _setsRepository.GetSetById<SetWithoutCardsModel>(setId, contextPath);
            var set = _mapper.Map<SetWithoutCardsDto>(setModel);
            return set;
        }
    }
}
