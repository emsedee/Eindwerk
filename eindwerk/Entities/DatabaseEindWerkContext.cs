using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace eindwerk.Entities
{
    public class DatabaseEindWerkContext : IdentityDbContext<IdentityUser>
    {
        public DatabaseEindWerkContext()
        {
        }

        public DatabaseEindWerkContext(DbContextOptions<DatabaseEindWerkContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BesteldeOnderdelen> BesteldeOnderdelen { get; set; }
        public virtual DbSet<Bestellingen> Bestellingen { get; set; }
        public virtual DbSet<Betrokkenheid> Betrokkenheid { get; set; }
        public virtual DbSet<Competentie> Competentie { get; set; }
        public virtual DbSet<Facturen> Facturen { get; set; }
        public virtual DbSet<Fotos> Fotos { get; set; }
        public virtual DbSet<InterventieCompetenties> InterventieCompetenties { get; set; }
        public virtual DbSet<Interventies> Interventies { get; set; }
        public virtual DbSet<Kennisgebieden> Kennisgebieden { get; set; }
        public virtual DbSet<Leverancier> Leverancier { get; set; }
        public virtual DbSet<Locatie> Locatie { get; set; }
        public virtual DbSet<Niveau> Niveau { get; set; }
        public virtual DbSet<Onderdelen> Onderdelen { get; set; }
        public virtual DbSet<Onderdelencode> Onderdelencode { get; set; }
        public virtual DbSet<Personeelsleden> Personeelsleden { get; set; }
        public virtual DbSet<Prioriteit> Prioriteit { get; set; }
        public virtual DbSet<Tablet> Tablet { get; set; }
        public virtual DbSet<TabletPersoneelsLeden> TabletPersoneelsLeden { get; set; }
        public virtual DbSet<Toestel> Toestel { get; set; }
        public virtual DbSet<Voorraad> Voorraad { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-0FFQO7L\SQLEXPRESS;Initial Catalog=DatabaseEindWerk;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<BesteldeOnderdelen>(entity =>
            {
                entity.HasKey(e => new { e.OnderdeelId, e.BestelId })
                    .HasName("PK__tmp_ms_x__EA0C1B679AED5673");

                entity.ToTable("Bestelde onderdelen");

                entity.Property(e => e.OnderdeelId).HasColumnName("Onderdeel_id");

                entity.Property(e => e.BestelId)
                    .HasColumnName("Bestel_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OnderdelencodeLeverancier)
                    .HasColumnName("Onderdelencode_leverancier")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bestellingen>(entity =>
            {
                entity.HasKey(e => e.BestelId)
                    .HasName("PK__Bestelli__4ADAAA2FF29D6105");

                entity.Property(e => e.BestelId).HasColumnName("Bestel_id");

                entity.Property(e => e.Besteldatum).HasMaxLength(10);

                entity.Property(e => e.FactuurId).HasColumnName("Factuur_id");

                entity.Property(e => e.InterventieId).HasColumnName("Interventie_id");

                entity.Property(e => e.LeveranciersId).HasColumnName("Leveranciers_id");

                entity.Property(e => e.LeveringsDatum).HasMaxLength(10);

                entity.Property(e => e.PersoneelsId).HasColumnName("Personeels_id");

                entity.HasOne(d => d.Factuur)
                    .WithMany(p => p.Bestellingen)
                    .HasForeignKey(d => d.FactuurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bestellingen_Facturen");

                entity.HasOne(d => d.Interventie)
                    .WithMany(p => p.Bestellingen)
                    .HasForeignKey(d => d.InterventieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bestellingen_Interventies");

                entity.HasOne(d => d.Leveranciers)
                    .WithMany(p => p.Bestellingen)
                    .HasForeignKey(d => d.LeveranciersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bestellingen_Leverancier");

                entity.HasOne(d => d.Personeels)
                    .WithMany(p => p.Bestellingen)
                    .HasForeignKey(d => d.PersoneelsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bestellingen_Personeelsleden");
            });

            modelBuilder.Entity<Betrokkenheid>(entity =>
            {
                entity.HasKey(e => new { e.InterventieId, e.PersoneelsId })
                    .HasName("PK__tmp_ms_x__79F489B0893BB803");

                entity.Property(e => e.InterventieId)
                    .HasColumnName("Interventie_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PersoneelsId).HasColumnName("Personeels_id");

                entity.Property(e => e.Begin).HasColumnType("datetime");

                entity.Property(e => e.Einde).HasColumnType("datetime");
            });

            modelBuilder.Entity<Competentie>(entity =>
            {
                entity.HasKey(e => new { e.PersoneelsId, e.SpecialisatieId })
                    .HasName("PK__tmp_ms_x__A24EA4A2DD4B802B");

                entity.Property(e => e.PersoneelsId)
                    .HasColumnName("Personeels_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SpecialisatieId).HasColumnName("Specialisatie_id");

                entity.Property(e => e.DatumVerworven)
                    .HasColumnName("Datum verworven")
                    .HasColumnType("datetime");

                entity.Property(e => e.Niveau).HasMaxLength(10);

                entity.Property(e => e.NiveauId).HasColumnName("Niveau_id");

                entity.HasOne(d => d.NiveauNavigation)
                    .WithMany(p => p.Competentie)
                    .HasForeignKey(d => d.NiveauId)
                    .HasConstraintName("FK_Competentie_Niveau");
            });

            modelBuilder.Entity<Facturen>(entity =>
            {
                entity.HasKey(e => e.FactuurId)
                    .HasName("PK__tmp_ms_x__C70C0B1C87BB52CC");

                entity.Property(e => e.FactuurId).HasColumnName("Factuur_id");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.VervalDatum).HasColumnType("datetime");
            });

            modelBuilder.Entity<Fotos>(entity =>
            {
                entity.HasKey(e => e.FotoId)
                    .HasName("PK__tmp_ms_x__729FCD7646B6130A");

                entity.Property(e => e.FotoId).HasColumnName("Foto_id");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasColumnType("image");

                entity.Property(e => e.InterventieId).HasColumnName("Interventie_id");

                entity.HasOne(d => d.Interventie)
                    .WithMany(p => p.Fotos)
                    .HasForeignKey(d => d.InterventieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fotos_Interventies");
            });

            modelBuilder.Entity<InterventieCompetenties>(entity =>
            {
                entity.HasKey(e => new { e.InterventieId, e.SpecialisatieId, e.PersoneelsId })
                    .HasName("PK__Interven__C34FE9FD08A23F7A");

                entity.ToTable("Interventie competenties");

                entity.Property(e => e.InterventieId).HasColumnName("Interventie_id");

                entity.Property(e => e.SpecialisatieId).HasColumnName("Specialisatie_id");

                entity.Property(e => e.PersoneelsId).HasColumnName("Personeels_id");

                entity.HasOne(d => d.Interventie)
                    .WithMany(p => p.InterventieCompetenties)
                    .HasForeignKey(d => d.InterventieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Interventie competenties_Interventies");

                entity.HasOne(d => d.Personeels)
                    .WithMany(p => p.InterventieCompetenties)
                    .HasForeignKey(d => d.PersoneelsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Interventie competenties_Personeelsleden");

                entity.HasOne(d => d.Specialisatie)
                    .WithMany(p => p.InterventieCompetenties)
                    .HasForeignKey(d => d.SpecialisatieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Interventie competenties_Kennisgebieden");
            });

            modelBuilder.Entity<Interventies>(entity =>
            {
                entity.HasKey(e => e.InterventieId)
                    .HasName("PK__tmp_ms_x__68723851FA4143A3");

                entity.Property(e => e.InterventieId).HasColumnName("Interventie_id");

                entity.Property(e => e.BestelId).HasColumnName("Bestel_id");

                entity.Property(e => e.Complexiteit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Duur)
                    .HasColumnName("duur")
                    .HasColumnType("datetime");

                entity.Property(e => e.Einddatum).HasColumnType("datetime");

                entity.Property(e => e.Meldingsdatum).HasColumnType("datetime");

                entity.Property(e => e.Omschrijving).IsUnicode(false);

                entity.Property(e => e.OmschrijvingOplossing)
                    .HasColumnName("Omschrijving oplossing")
                    .IsUnicode(false);

                entity.Property(e => e.PersoneelsId).HasColumnName("Personeels_id");

                entity.Property(e => e.PrioriteitId).HasColumnName("Prioriteit_id");

                entity.Property(e => e.Status)
                    .HasColumnName("Soort interventie")
                    .HasMaxLength(50);

                entity.Property(e => e.ToestelId).HasColumnName("Toestel_id");

                entity.Property(e => e.Verwachtteoplossingstermijn).HasColumnType("datetime");

                entity.HasOne(d => d.Bestel)
                    .WithMany(p => p.Interventies)
                    .HasForeignKey(d => d.BestelId)
                    .HasConstraintName("FK_Interventies_Bestellingen");

                entity.HasOne(d => d.Personeels)
                    .WithMany(p => p.Interventies)
                    .HasForeignKey(d => d.PersoneelsId)
                    .HasConstraintName("FK_Interventies_Personeelsleden");

                entity.HasOne(d => d.Prioriteit)
                    .WithMany(p => p.Interventies)
                    .HasForeignKey(d => d.PrioriteitId)
                    .HasConstraintName("FK_Interventies_Prioriteit");

                entity.HasOne(d => d.Toestel)
                    .WithMany(p => p.Interventies)
                    .HasForeignKey(d => d.ToestelId)
                    .HasConstraintName("FK_Interventies_Toestel");
            });

            modelBuilder.Entity<Kennisgebieden>(entity =>
            {
                entity.HasKey(e => e.SpecialisatieId)
                    .HasName("PK__tmp_ms_x__A25BAB2A13FCB8E7");

                entity.Property(e => e.SpecialisatieId).HasColumnName("Specialisatie_id");

                entity.Property(e => e.KorteOmschrijving)
                    .HasColumnName("Korte omschrijving")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LangeOmschrijving)
                    .HasColumnName("Lange omschrijving")
                    .IsUnicode(false);

                entity.Property(e => e.SoortKennisgebied)
                    .HasColumnName("Soort kennisgebied")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Leverancier>(entity =>
            {
                entity.HasKey(e => e.LeveranciersId)
                    .HasName("PK__tmp_ms_x__86F35737B1965161");

                entity.Property(e => e.LeveranciersId).HasColumnName("Leveranciers_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Huisnummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Naam)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Postcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Straat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefoon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Website).IsUnicode(false);
            });

            modelBuilder.Entity<Locatie>(entity =>
            {
                entity.Property(e => e.LocatieId).HasColumnName("Locatie_id");

                entity.Property(e => e.Oppervlakte).HasMaxLength(10);

                entity.Property(e => e.SoortRuimte)
                    .HasColumnName("Soort Ruimte")
                    .HasMaxLength(10);

                entity.Property(e => e.VoorraadPlaatsen).HasMaxLength(10);
            });

            modelBuilder.Entity<Niveau>(entity =>
            {
                entity.Property(e => e.NiveauId).HasColumnName("Niveau_id");

                entity.Property(e => e.Beginner)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ervaren)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Expert)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Onderdelen>(entity =>
            {
                entity.HasKey(e => new { e.ToestelId, e.OnderdeelId })
                    .HasName("PK__Onderdel__DA156EBD7C3D2624");

                entity.Property(e => e.ToestelId).HasColumnName("Toestel_id");

                entity.Property(e => e.OnderdeelId).HasColumnName("Onderdeel_id");

                entity.Property(e => e.Kleur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Omschrijving).IsUnicode(false);

                entity.Property(e => e.ParentonderdeelId).HasColumnName("Parentonderdeel_ID");

                entity.HasOne(d => d.Toestel)
                    .WithMany(p => p.Onderdelen)
                    .HasForeignKey(d => d.ToestelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Onderdelen_Toestel");
            });

            modelBuilder.Entity<Onderdelencode>(entity =>
            {
                entity.HasKey(e => new { e.LeveranciersId, e.OnderdeelId })
                    .HasName("PK__Onderdel__C6194C2B479C3972");

                entity.Property(e => e.LeveranciersId).HasColumnName("Leveranciers_id");

                entity.Property(e => e.OnderdeelId).HasColumnName("Onderdeel_id");

                entity.Property(e => e.OnderdelencodeLeverancier).HasColumnName("Onderdelencode_leverancier");
            });

            modelBuilder.Entity<Personeelsleden>(entity =>
            {
                entity.HasKey(e => e.PersoneelsId)
                    .HasName("PK__tmp_ms_x__186B1E10991444A9");

                entity.Property(e => e.PersoneelsId).HasColumnName("Personeels_id");

                entity.Property(e => e.Foto).HasColumnType("image");

                entity.Property(e => e.GsmNummer).HasColumnName("Gsm Nummer");

                entity.Property(e => e.Naam)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoortPersoneelslid)
                    .HasColumnName("Soort Personeelslid")
                    .HasMaxLength(50);

                entity.Property(e => e.Voornaam)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Prioriteit>(entity =>
            {
                entity.Property(e => e.PrioriteitId).HasColumnName("Prioriteit_id");

                entity.Property(e => e._Prioriteit).HasMaxLength(10);

            });

            modelBuilder.Entity<Tablet>(entity =>
            {
                entity.Property(e => e.TabletId).HasColumnName("Tablet_id");

                entity.Property(e => e.BesturingsSysteeem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Merk)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SchermType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TabletPersoneelsLeden>(entity =>
            {
                entity.HasKey(e => new { e.TabletId, e.PersoneelsId })
                    .HasName("PK__TabletPe__7FF187720B2D43F7");

                entity.Property(e => e.TabletId).HasColumnName("Tablet_id");

                entity.Property(e => e.PersoneelsId).HasColumnName("Personeels_id");

                entity.HasOne(d => d.Personeels)
                    .WithMany(p => p.TabletPersoneelsLeden)
                    .HasForeignKey(d => d.PersoneelsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TabletPersoneelsLeden_Personeelsleden");

                entity.HasOne(d => d.Tablet)
                    .WithMany(p => p.TabletPersoneelsLeden)
                    .HasForeignKey(d => d.TabletId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TabletPersoneelsLeden_Tablet");
            });

            modelBuilder.Entity<Toestel>(entity =>
            {
                entity.Property(e => e.ToestelId).HasColumnName("Toestel_id");

                entity.Property(e => e.DatumAfschrijving).HasColumnType("datetime");

                entity.Property(e => e.Keuring).HasColumnType("datetime");

                entity.Property(e => e.LocatieId).HasColumnName("Locatie_id");

                entity.Property(e => e.Materie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaximumGewicht).HasColumnName("Maximum gewicht");

                entity.Property(e => e.Merk)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Naam)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Omschrijving).IsUnicode(false);

                entity.Property(e => e.SoortToestel)
                    .HasColumnName("Soort toestel")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeAandrijving)
                    .HasColumnName("Type aandrijving")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeMatras)
                    .HasColumnName("Type matras")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Locatie)
                    .WithMany(p => p.Toestel)
                    .HasForeignKey(d => d.LocatieId)
                    .HasConstraintName("FK_Toestel_Locatie");
            });

            modelBuilder.Entity<Voorraad>(entity =>
            {
                entity.HasKey(e => new { e.OnderdeelId, e.LocatieId })
                    .HasName("PK__Voorraad__B50DF978AA0CFCC1");

                entity.Property(e => e.OnderdeelId).HasColumnName("Onderdeel_id");

                entity.Property(e => e.LocatieId).HasColumnName("Locatie_id");
            });
        }
    }
}
