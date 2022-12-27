using RawDealDb.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDealDb.Core.DTO
{
    public class SearchByDto
    {
        public Dictionary<int, string> SearchByValues { get; } = new Dictionary<int, string>
        {
            { (int)SearchByEnum.Set, "Set" },
            { (int)SearchByEnum.CardName, "Card name" },
            { (int)SearchByEnum.Fortitude, "Fortitude" },
            { (int)SearchByEnum.Damage, "Damage" },
            { (int)SearchByEnum.SuperStarValue, "Super star value" },
            { (int)SearchByEnum.SuperStarLogo, "Super star" },
            { (int)SearchByEnum.Traits, "Traits" },
            { (int)SearchByEnum.CardText, "Card text" }
        };
    }
}
