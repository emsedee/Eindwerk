using System;
using System.Collections.Generic;

namespace eindwerk.Entities
{
    public partial class Fotos
    {
        public int FotoId { get; set; }
        public int InterventieId { get; set; }
        public byte[] Image { get; set; }

        public virtual Interventies Interventie { get; set; }
    }
}
