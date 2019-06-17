using System;
using System.Collections.Generic;

namespace eindwerk.Entities
{
    public partial class Prioriteit
    {
        public Prioriteit()
        {
            Interventies = new HashSet<Interventies>();
        }

        public int PrioriteitId { get; set; }
        public string _Prioriteit { get; set; }
        

        public virtual ICollection<Interventies> Interventies { get; set; }
    }
}
