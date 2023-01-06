using Microsoft.Extensions.Configuration;
using RawDealDb.Core.DTO;
using RawDealDb.Core.Interfaces.DAL;
using RawDealDb.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDealDb.Infrastructure.Repositories
{
    public class CardRepository : ICardRepository
    {
        private readonly ISetsRepository _setsRepository;
        public CardRepository(ISetsRepository setsRepository)
        {
            _setsRepository = setsRepository;
        }
        public async Task<IEnumerable<string>> GetAllCardNames(string contextPath)
        {
            var setList = _setsRepository.GetAllSets<SetWithCardsModel>(contextPath);
            var cardList = setList.Select(x => x.Cards);
            var cardNames = new List<string>();
            foreach (var cards in cardList)
            {
                cards.ForEach(c => cardNames.Add(c.Name));
            }
            return cardNames;
        }

        public async Task<IEnumerable<CardModel>> GetAllCards(string contextPath)
        {
            var setList = _setsRepository.GetAllSets<SetWithCardsModel>(contextPath);
            var cardModelList = new List<CardModel>();
            foreach (var set in setList)
            {
                set.Cards.ToList().ForEach(x => x.SetId = set.Id);
                set.Cards.ToList().ForEach(x => x.SetName = set.Name);
                cardModelList = cardModelList.Concat(set.Cards).ToList();
            }
            return cardModelList;
        }
    }
}
