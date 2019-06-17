using System;
using System.Collections.Generic;

namespace eindwerk.Entities
{
    public partial class Onderdelencode
    {
        public int LeveranciersId { get; set; }
        public int OnderdeelId { get; set; }
        public string OnderdelencodeLeverancier { get; set; }
        public int? Aankoopprijs { get; set; }
    }
}
