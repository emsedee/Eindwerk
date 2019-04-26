using System;
using System.Collections.Generic;

namespace eindwerk.Entities
{
    public partial class TabletPersoneelsLeden
    {
        public int TabletId { get; set; }
        public int PersoneelsId { get; set; }

        public virtual Personeelsleden Personeels { get; set; }
        public virtual Tablet Tablet { get; set; }
    }
}
