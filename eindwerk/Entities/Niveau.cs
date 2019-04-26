using System;
using System.Collections.Generic;

namespace eindwerk.Entities
{
    public partial class Niveau
    {
        public Niveau()
        {
            Competentie = new HashSet<Competentie>();
        }

        public int NiveauId { get; set; }
        public string Beginner { get; set; }
        public string Ervaren { get; set; }
        public string Expert { get; set; }

        public virtual ICollection<Competentie> Competentie { get; set; }
    }
}
