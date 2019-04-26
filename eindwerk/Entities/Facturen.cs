using System;
using System.Collections.Generic;

namespace eindwerk.Entities
{
    public partial class Facturen
    {
        public Facturen()
        {
            Bestellingen = new HashSet<Bestellingen>();
        }

        public int FactuurId { get; set; }
        public DateTime? Datum { get; set; }
        public DateTime? VervalDatum { get; set; }

        public virtual ICollection<Bestellingen> Bestellingen { get; set; }
    }
}
