using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDealDb.Core.Constants
{
    public static class TypeConstants
    {
        public static List<string> ManeuverTypes = new List<string>
        {
            "Strike",
            "Grapple",
            "Submission",
            "Trademark Finisher"
        };

        public const string ManeuverColor = "#dbaa1f";
        public const string ActionColor = "#4b65a2";
        public const string ReversalColor = "#a73326";
        public const string Prematch = "#4d325d";

    }
}
