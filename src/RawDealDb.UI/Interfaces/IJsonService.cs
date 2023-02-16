using RawDealDb.Core.DTO;

namespace RawDealDb.UI.Interfaces
{
    public interface IJsonService
    {
        Task<List<ChangeLogDto>> GetChangelogs();
    }
}
