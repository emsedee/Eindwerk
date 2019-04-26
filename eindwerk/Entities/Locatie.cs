using System;
using System.Collections.Generic;

namespace eindwerk.Entities
{
    public partial class Locatie
    {
        public Locatie()
        {
            Toestel = new HashSet<Toestel>();
        }

        public int LocatieId { get; set; }
        public string VoorraadPlaatsen { get; set; }
        public string Oppervlakte { get; set; }
        public string SoortRuimte { get; set; }

        public virtual ICollection<Toestel> Toestel { get; set; }
    }
}
