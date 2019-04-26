using System;
using System.Collections.Generic;

namespace eindwerk.Entities
{
    public partial class Leverancier
    {
        public Leverancier()
        {
            Bestellingen = new HashSet<Bestellingen>();
        }

        public int LeveranciersId { get; set; }
        public string Naam { get; set; }
        public string Telefoon { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Straat { get; set; }
        public string Huisnummer { get; set; }
        public string Postcode { get; set; }
        public string Stad { get; set; }

        public virtual ICollection<Bestellingen> Bestellingen { get; set; }
    }
}
