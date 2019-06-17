using System;
using System.Collections.Generic;

namespace eindwerk.Entities
{
    public partial class Toestel
    {
        public Toestel()
        {
            Interventies = new HashSet<Interventies>();
            Onderdelen = new HashSet<Onderdelen>();
        }

        public int ToestelId { get; set; }
        public string Naam { get; set; }
        public string Merk { get; set; }
        public DateTime? Keuring { get; set; }
        public int? Ouderdom { get; set; }
        public string Omschrijving { get; set; }
        public int? Formaat { get; set; }
        public int? MaximumGewicht { get; set; }
        public string TypeMatras { get; set; }
        public string TypeAandrijving { get; set; }
        public bool? Opplooibaar { get; set; }
        public bool? Verstelbaar { get; set; }
        public string Materie { get; set; }
        public DateTime? DatumAfschrijving { get; set; }
        public int? LocatieId { get; set; }
        public string SoortToestel { get; set; }

        public virtual Locatie Locatie { get; set; }
        public virtual ICollection<Interventies> Interventies { get; set; }
        public virtual ICollection<Onderdelen> Onderdelen { get; set; }
    }
}
