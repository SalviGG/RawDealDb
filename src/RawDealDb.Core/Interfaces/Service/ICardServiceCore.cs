using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDealDb.Core.Interfaces.Service
{
    public interface ICardServiceCore
    {
        Task<IEnumerable<string>> SearchCardsByName(string searchName, string contextPath);
    }
}
