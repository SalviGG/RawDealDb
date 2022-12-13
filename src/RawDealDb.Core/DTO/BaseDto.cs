using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDealDb.Core.DTO
{
    public abstract class BaseDto
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
    }
}
