using System;
using System.Collections.Generic;

namespace eindwerk.Entities
{
    public partial class BesteldeOnderdelen
    {
        public int BestelId { get; set; }
        public int OnderdeelId { get; set; }
        public string OnderdelencodeLeverancier { get; set; }
        public int? Aantal { get; set; }
    }
}
