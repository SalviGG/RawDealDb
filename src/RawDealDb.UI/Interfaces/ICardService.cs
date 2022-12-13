namespace RawDealDb.UI.Interfaces
{
    public interface ICardService
    {
        Task<IEnumerable<string>> SearchCardsByName(string searchName);
    }
}
