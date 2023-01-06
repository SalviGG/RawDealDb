using RawDealDb.Core.DTO;

namespace RawDealDb.UI.Interfaces
{
    public interface IChangelogService
    {
        Task<List<ChangeLogDto>> GetChangelogs();
    }
}
