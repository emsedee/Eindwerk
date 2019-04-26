using System;
using System.Collections.Generic;

namespace eindwerk.Entities
{
    public partial class Betrokkenheid
    {
        public int InterventieId { get; set; }
        public int PersoneelsId { get; set; }
        public DateTime? Begin { get; set; }
        public DateTime? Einde { get; set; }
    }
}
