using System;
using System.Collections.Generic;

namespace eindwerk.Entities
{
    public class Interventies
    {

        public Interventies()
        {
            Bestellingen = new HashSet<Bestellingen>();
            Fotos = new HashSet<Fotos>();
            InterventieCompetenties = new HashSet<InterventieCompetenties>();
        }

        public int InterventieId { get; set; }
        public string Complexiteit { get; set; }
        public DateTime? Meldingsdatum { get; set; }
        public string Omschrijving { get; set; }
        public DateTime? Einddatum { get; set; }
        public DateTime? Duur { get; set; }
        public DateTime? Verwachtteoplossingstermijn { get; set; }
        public string OmschrijvingOplossing { get; set; }
        public int? PersoneelsId { get; set; }
        public int? PrioriteitId { get; set; }
        public int? ToestelId { get; set; }
        public int? BestelId { get; set; }
        public Status Status { get; set; }
       

        public virtual Bestellingen Bestel { get; set; }
        public virtual Personeelsleden Personeels { get; set; }
        public virtual Prioriteit Prioriteit { get; set; }
        public virtual Toestel Toestel { get; set; }
        public virtual ICollection<Bestellingen> Bestellingen { get; set; }
        public virtual ICollection<Fotos> Fotos { get; set; }
        public virtual ICollection<InterventieCompetenties> InterventieCompetenties { get; set; }
    }
    public enum Status
    { Open, Toegewezen, Opgelost }
}
