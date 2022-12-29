using RawDealDb.Core.DTO;
using RawDealDb.Core.Interfaces.Service;
using RawDealDb.UI.Interfaces;

namespace RawDealDb.UI.Services
{
    public class ChangelogService : IChangelogService
    {
        private IChangelogServiceCore _changelogServiceCore;
        private string _rootPath;
        public ChangelogService(IChangelogServiceCore changelogServiceCore)
        {
            _changelogServiceCore = changelogServiceCore;
            _rootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "changelog");
        }

        public async Task<List<ChangeLogDto>> GetChangelogs()
        {
            var path = Path.Combine(_rootPath, "changelog.json");
            var changelogList = await _changelogServiceCore.GetChangelogAsync(path);
            return changelogList;
        }
    }
}
