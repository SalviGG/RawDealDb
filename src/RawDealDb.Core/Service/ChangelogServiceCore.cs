using RawDealDb.Core.DTO;
using RawDealDb.Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RawDealDb.Core.Service
{
    public class ChangelogServiceCore : IChangelogServiceCore
    {
        public async Task<List<ChangeLogDto>> GetChangelogAsync(string contextPath)
        {
            using (var stream = File.OpenRead(contextPath))
            {
                return await JsonSerializer.DeserializeAsync<List<ChangeLogDto>>(stream);
            }
        }
    }
}
