using RawDealDb.Core.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDealDb.Core.DTO
{
    public class CardDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Format { get; set; }
        public string Traits { get; set; }
        public string CardType { get; set; }
        public string CardText { get; set; }
        public string Fortitude { get; set; }
        public string Damage { get; set; }
        public string HandSize { get; set; }
        public string SuperStarValue { get; set; }
        public string SuperStarLogo { get; set; }
        public Guid SetId { get; set; }
        public string SetName { get; set; }

        public int GetTypesQty
            ()
        {
            var splitTypes = CardType.Trim().Split("/");
            return splitTypes.Count();
        }

        public string ParseType()
        {
            var typesQty = GetTypesQty();

            string cardTypeParsed = "";
            if ((CardType.Equals("strike", StringComparison.OrdinalIgnoreCase) ||
            CardType.Equals("grapple", StringComparison.OrdinalIgnoreCase) ||
            CardType.Equals("submission", StringComparison.OrdinalIgnoreCase)) && typesQty == 1)
            {
                cardTypeParsed = "Maneuver";
            }
            else if (CardType.Equals("action", StringComparison.OrdinalIgnoreCase) && typesQty == 1 )
            {
                cardTypeParsed = "Action";
            }
            else if (CardType.Contains("Reversal") && typesQty == 1)
            {
                cardTypeParsed = "Reversal";
            }
            else if (typesQty > 1 && TypeConstants.ManeuverTypes.Any(x => CardType.Contains(x)) && CardType.Contains("Reversal"))
            {
                cardTypeParsed = "Maneuver Reversal";
            }
            else if (CardType.Contains("Pre-match"))
            {
                cardTypeParsed = "Pre-match";
            }

            return cardTypeParsed;
        }

    }
}
