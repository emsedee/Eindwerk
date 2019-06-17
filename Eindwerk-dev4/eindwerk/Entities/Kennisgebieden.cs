using System;
using System.Collections.Generic;

namespace eindwerk.Entities
{
    public partial class Kennisgebieden
    {
        public Kennisgebieden()
        {
            InterventieCompetenties = new HashSet<InterventieCompetenties>();
        }

        public int SpecialisatieId { get; set; }
        public string KorteOmschrijving { get; set; }
        public string LangeOmschrijving { get; set; }
        public string SoortKennisgebied { get; set; }

        public virtual ICollection<InterventieCompetenties> InterventieCompetenties { get; set; }
    }
}
