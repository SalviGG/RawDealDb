using RawDealDb.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDealDb.Core.Interfaces.Service
{
    public interface IChangelogServiceCore
    {
        Task<List<ChangeLogDto>> GetChangelogAsync(string contextPath);
    }
}
