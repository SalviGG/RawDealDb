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
        public CardServiceCore(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public async Task<IEnumerable<string>> SearchCardsByName(string searchName, string contextPath)
        {
            var cardNames = await _cardRepository.GetAllCardNames(contextPath);
            return cardNames.Where(x => x.Contains(searchName, StringComparison.InvariantCultureIgnoreCase));
        }

        //public async Task<IEnumerable<CardDto>> GetAllCards(string conte)
        //{

        //}
    }
}
