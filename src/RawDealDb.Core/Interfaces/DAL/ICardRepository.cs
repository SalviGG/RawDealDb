using RawDealDb.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDealDb.Core.Interfaces.DAL
{
    public interface ICardRepository
    {
        Task<IEnumerable<string>> GetAllCardNames(string contextPath);
        Task<IEnumerable<CardModel>> GetAllCards(string contextPath);
    }
}
