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
    public class JsonMappingServiceCore : IJsonMappingServiceCore
    {
        public async Task<T> GetJsonMappedAsync<T>(string contextPath) where T : class
        {
            using (var stream = File.OpenRead(contextPath))
            {
                return await JsonSerializer.DeserializeAsync<T>(stream);
            }
        }
    }
}
