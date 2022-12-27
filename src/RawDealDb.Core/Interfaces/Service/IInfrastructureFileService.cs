using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDealDb.Core.Interfaces.Service
{
    public interface IInfrastructureFileService
    {
        string GetFile(string contextPath, string fileName);
    }
}
