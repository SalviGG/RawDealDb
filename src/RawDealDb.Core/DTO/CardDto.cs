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
        public string CardText { get; set; }
        public string Fortitude { get; set; }
        public string Damage { get; set; }
        public string HandSize { get; set; }
        public string SuperStarValue { get; set; }
        public Guid SetId { get; set; }
        //public List<CardPropertyDto> Properties { get; set; }
    }
}
