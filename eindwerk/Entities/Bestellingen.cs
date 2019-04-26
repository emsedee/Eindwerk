using System;
using System.Collections.Generic;

namespace eindwerk.Entities
{
    public partial class Bestellingen
    {
        public Bestellingen()
        {
            Interventies = new HashSet<Interventies>();
        }

        public int BestelId { get; set; }
        public string Besteldatum { get; set; }
        public string LeveringsDatum { get; set; }
        public int LeveranciersId { get; set; }
        public int PersoneelsId { get; set; }
        public int FactuurId { get; set; }
        public int InterventieId { get; set; }

        public virtual Facturen Factuur { get; set; }
        public virtual Interventies Interventie { get; set; }
        public virtual Leverancier Leveranciers { get; set; }
        public virtual Personeelsleden Personeels { get; set; }
        public virtual ICollection<Interventies> Interventies { get; set; }
    }
}
