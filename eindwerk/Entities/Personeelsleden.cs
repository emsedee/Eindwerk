using System;
using System.Collections.Generic;

namespace eindwerk.Entities
{
    public partial class Personeelsleden
    {
        public Personeelsleden()
        {
            Bestellingen = new HashSet<Bestellingen>();
            InterventieCompetenties = new HashSet<InterventieCompetenties>();
            Interventies = new HashSet<Interventies>();
            TabletPersoneelsLeden = new HashSet<TabletPersoneelsLeden>();
        }

        public int PersoneelsId { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string GsmNummer { get; set; }
        public string Emailadres { get; set; }
        public byte[] Foto { get; set; }
        public string SoortPersoneelslid { get; set; }

        public virtual ICollection<Bestellingen> Bestellingen { get; set; }
        public virtual ICollection<InterventieCompetenties> InterventieCompetenties { get; set; }
        public virtual ICollection<Interventies> Interventies { get; set; }
        public virtual ICollection<TabletPersoneelsLeden> TabletPersoneelsLeden { get; set; }
    }
}
