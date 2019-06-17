using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eindwerk.Entities
{
    public partial class Locatie
    {
        public Locatie()
        {
            Toestel = new HashSet<Toestel>();
        }

        public int LocatieId { get; set; }
        public int VoorraadPlaatsen { get; set; }
        public int Oppervlakte { get; set; }
        public string SoortRuimte { get; set; }
        public string Naam { get; set; }
        public virtual ICollection<Toestel> Toestel { get; set; }
    }
}
