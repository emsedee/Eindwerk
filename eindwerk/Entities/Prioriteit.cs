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
        public string Gewoon { get; set; }
        public string Dringend { get; set; }
        public string ZeerDringen { get; set; }
        public string HoogDringend { get; set; }

        public virtual ICollection<Interventies> Interventies { get; set; }
    }
}
