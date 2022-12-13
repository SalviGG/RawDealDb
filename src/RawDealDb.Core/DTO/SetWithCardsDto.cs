using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDealDb.Core.DTO
{
    public class SetWithCardsDto : BaseDto
    {
        public List<CardDto> Cards { get; set; }
    }
}
