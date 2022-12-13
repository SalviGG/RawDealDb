using RawDealDb.Core.Interfaces.Service;
using RawDealDb.UI.Interfaces;

namespace RawDealDb.UI.Services
{
    public class CardService : ICardService
    {
        private readonly ICardServiceCore _cardServiceCore;
        public CardService(ICardServiceCore cardServiceCore)
        {
            _cardServiceCore = cardServiceCore;
        }

        public Task<IEnumerable<string>> SearchCardsByName(string searchName)
        {
            string rootpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
            var cardNames = _cardServiceCore.SearchCardsByName(searchName, rootpath);
            return cardNames;
        }
    }
}
