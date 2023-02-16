using RawDealDb.Core.DTO;
using RawDealDb.Core.DTO.OmniFaqDTO;
using RawDealDb.Core.Interfaces.Service;
using RawDealDb.UI.Interfaces;

namespace RawDealDb.UI.Services
{
    public class JsonService : IJsonService
    {
        private IJsonMappingServiceCore _JsonMappingServiceCore;
        private string _rootPath;
        public JsonService(IJsonMappingServiceCore changelogServiceCore)
        {
            _JsonMappingServiceCore = changelogServiceCore;
            _rootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
        }

        public async Task<List<ChangeLogDto>> GetChangelogs()
        {
            var path = Path.Combine(_rootPath, "changelog", "changelog.json");
            var changelogList = await _JsonMappingServiceCore.GetJsonMappedAsync<List<ChangeLogDto>>(path);
            return changelogList;
        }

        public async Task<OmniFaqDto> GetOmniFaq()
        {
            var path = Path.Combine(_rootPath, "docs", "omnifaq.json");
            var omnifaq = await _JsonMappingServiceCore.GetJsonMappedAsync<OmniFaqDto>(path);
            return omnifaq;
        }
    }
}
