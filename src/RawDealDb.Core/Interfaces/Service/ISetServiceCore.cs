using RawDealDb.Core.DTO;
using RawDealDb.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDealDb.Core.Interfaces.Service
{
    public interface ISetServiceCore
    {
        IEnumerable<SetWithoutCardsDto> GetAllSets(string contextPath);
        SetWithCardsDto GetSetWithCardsById(string setId, string contextPath);
        SetWithoutCardsDto GetSetWithoutCardsById(string setId, string contextPath);
    }
}
