using System;
using System.Collections.Generic;

namespace eindwerk.Entities
{
    public partial class Voorraad
    {
        public int OnderdeelId { get; set; }
        public int LocatieId { get; set; }
        public int? Aantal { get; set; }
    }
}
