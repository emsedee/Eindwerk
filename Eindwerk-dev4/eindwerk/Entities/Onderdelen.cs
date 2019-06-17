using System;
using System.Collections.Generic;

namespace eindwerk.Entities
{
    public partial class Onderdelen
    {
        public int ToestelId { get; set; }
        public int OnderdeelId { get; set; }
        public string Kleur { get; set; }
        public string Omschrijving { get; set; }
        public int? Formaat { get; set; }
        public int? Gewicht { get; set; }
        public int? ParentonderdeelId { get; set; }

        public virtual Toestel Toestel { get; set; }
    }
}
