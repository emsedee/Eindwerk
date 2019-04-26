using System;
using System.Collections.Generic;

namespace eindwerk.Entities
{
    public partial class InterventieCompetenties
    {
        public int InterventieId { get; set; }
        public int PersoneelsId { get; set; }
        public int SpecialisatieId { get; set; }

        public virtual Interventies Interventie { get; set; }
        public virtual Personeelsleden Personeels { get; set; }
        public virtual Kennisgebieden Specialisatie { get; set; }
    }
}
