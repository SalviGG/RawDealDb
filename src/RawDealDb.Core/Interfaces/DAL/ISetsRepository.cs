using RawDealDb.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDealDb.Core.Interfaces.DAL
{
    public interface ISetsRepository
    {
        IEnumerable<T> GetAllSets<T>(string contextPath) where T : class;
        T GetSetById<T>(string setId, string contextPath) where T : class;
    }
}
