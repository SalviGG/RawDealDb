using RawDealDb.Core.DTO;
using RawDealDb.Core.Interfaces.Service;
using RawDealDb.UI.Interfaces;

namespace RawDealDb.UI.Services
{
    public class CardService : ICardService
    {
        private readonly ICardServiceCore _cardServiceCore;
        private string _rootPath;
        public CardService(ICardServiceCore cardServiceCore)
        {
            _cardServiceCore = cardServiceCore;
            _rootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
        }

        public Task<IEnumerable<string>> SearchCardsByName(string searchName)
        {
            var cardNames = _cardServiceCore.SearchCardsByName(searchName, _rootPath);
            return cardNames;
        }

        public async Task<IEnumerable<CardDto>> GetAllCards()
        {
            var cardList = await _cardServiceCore.GetAllCards(_rootPath);
            return cardList;
        }

    }
}
