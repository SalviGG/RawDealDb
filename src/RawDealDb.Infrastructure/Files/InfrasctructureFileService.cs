using RawDealDb.Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDealDb.Infrastructure.Files
{
    public class InfrasctructureFileService : IInfrastructureFileService
    {
        public string GetFile(string contextPath, string fileName)
        {
            var path = Path.Combine(contextPath, fileName);
            var file = File.ReadAllBytes(path);
            var b64File = Convert.ToBase64String(file);
            return b64File;
        }
    }
}
