using RawDealDb.Core.DTO;
using RawDealDb.Core.DTO.OmniFaqDTO;

namespace RawDealDb.UI.Interfaces
{
    public interface IJsonService
    {
        Task<List<ChangeLogDto>> GetChangelogs();
        Task<OmniFaqDto> GetOmniFaq();
    }
}
