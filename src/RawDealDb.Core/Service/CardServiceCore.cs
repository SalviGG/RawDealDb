using AutoMapper;
using RawDealDb.Core.DTO;
using RawDealDb.Core.Interfaces.DAL;
using RawDealDb.Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDealDb.Core.Service
{
    public class CardServiceCore : ICardServiceCore
    {
        private readonly ICardRepository _cardRepository;
        private readonly IMapper _mapper;
        public CardServiceCore(ICardRepository cardRepository, IMapper mapper)
        {
            _cardRepository = cardRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<string>> SearchCardsByName(string searchName, string contextPath)
        {
            var cardNames = await _cardRepository.GetAllCardNames(contextPath);
            return cardNames.Where(x => x.Contains(searchName, StringComparison.InvariantCultureIgnoreCase));
        }

        public async Task<IEnumerable<CardDto>> GetAllCards(string contextPath)
        {
            var cardListModel = await _cardRepository.GetAllCards(contextPath);
            var cardDtoList = _mapper.Map<IEnumerable<CardDto>>(cardListModel);
            return cardDtoList;
        }
    }
}
