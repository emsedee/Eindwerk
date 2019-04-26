using System;
using System.Collections.Generic;

namespace eindwerk.Entities
{
    public partial class Tablet
    {
        public Tablet()
        {
            TabletPersoneelsLeden = new HashSet<TabletPersoneelsLeden>();
        }

        public int TabletId { get; set; }
        public int? Prijs { get; set; }
        public string Merk { get; set; }
        public string BesturingsSysteeem { get; set; }
        public string SchermType { get; set; }
        public int? Resolutie { get; set; }

        public virtual ICollection<TabletPersoneelsLeden> TabletPersoneelsLeden { get; set; }
    }
}
