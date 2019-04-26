using System;
using System.Collections.Generic;

namespace eindwerk.Entities
{
    public partial class Competentie
    {
        public int PersoneelsId { get; set; }
        public int SpecialisatieId { get; set; }
        public string Niveau { get; set; }
        public int? NiveauId { get; set; }
        public DateTime? DatumVerworven { get; set; }

        public virtual Niveau NiveauNavigation { get; set; }
    }
}
