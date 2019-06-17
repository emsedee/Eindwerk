﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eindwerk.Entities;

namespace eindwerk.Data.Migrations
{
    [DbContext(typeof(DatabaseEindWerkContext))]
    [Migration("20190615155640_d2")]
    partial class d2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("eindwerk.Entities.BesteldeOnderdelen", b =>
                {
                    b.Property<int>("OnderdeelId")
                        .HasColumnName("Onderdeel_id");

                    b.Property<int>("BestelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Bestel_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Aantal");

                    b.Property<string>("OnderdelencodeLeverancier")
                        .HasColumnName("Onderdelencode_leverancier")
                        .IsUnicode(false);

                    b.HasKey("OnderdeelId", "BestelId")
                        .HasName("PK__tmp_ms_x__EA0C1B679AED5673");

                    b.ToTable("Bestelde onderdelen");
                });

            modelBuilder.Entity("eindwerk.Entities.Bestellingen", b =>
                {
                    b.Property<int>("BestelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Bestel_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Besteldatum")
                        .HasMaxLength(10);

                    b.Property<int>("FactuurId")
                        .HasColumnName("Factuur_id");

                    b.Property<int>("InterventieId")
                        .HasColumnName("Interventie_id");

                    b.Property<int>("LeveranciersId")
                        .HasColumnName("Leveranciers_id");

                    b.Property<string>("LeveringsDatum")
                        .HasMaxLength(10);

                    b.Property<int>("PersoneelsId")
                        .HasColumnName("Personeels_id");

                    b.HasKey("BestelId")
                        .HasName("PK__Bestelli__4ADAAA2FF29D6105");

                    b.HasIndex("FactuurId");

                    b.HasIndex("InterventieId");

                    b.HasIndex("LeveranciersId");

                    b.HasIndex("PersoneelsId");

                    b.ToTable("Bestellingen");
                });

            modelBuilder.Entity("eindwerk.Entities.Betrokkenheid", b =>
                {
                    b.Property<int>("InterventieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Interventie_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersoneelsId")
                        .HasColumnName("Personeels_id");

                    b.Property<DateTime?>("Begin")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Einde")
                        .HasColumnType("datetime");

                    b.HasKey("InterventieId", "PersoneelsId")
                        .HasName("PK__tmp_ms_x__79F489B0893BB803");

                    b.ToTable("Betrokkenheid");
                });

            modelBuilder.Entity("eindwerk.Entities.Competentie", b =>
                {
                    b.Property<int>("PersoneelsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Personeels_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SpecialisatieId")
                        .HasColumnName("Specialisatie_id");

                    b.Property<DateTime?>("DatumVerworven")
                        .HasColumnName("Datum verworven")
                        .HasColumnType("datetime");

                    b.Property<string>("Niveau")
                        .HasMaxLength(10);

                    b.Property<int?>("NiveauId")
                        .HasColumnName("Niveau_id");

                    b.HasKey("PersoneelsId", "SpecialisatieId")
                        .HasName("PK__tmp_ms_x__A24EA4A2DD4B802B");

                    b.HasIndex("NiveauId");

                    b.ToTable("Competentie");
                });

            modelBuilder.Entity("eindwerk.Entities.Facturen", b =>
                {
                    b.Property<int>("FactuurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Factuur_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Datum")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("VervalDatum")
                        .HasColumnType("datetime");

                    b.HasKey("FactuurId")
                        .HasName("PK__tmp_ms_x__C70C0B1C87BB52CC");

                    b.ToTable("Facturen");
                });

            modelBuilder.Entity("eindwerk.Entities.Fotos", b =>
                {
                    b.Property<int>("FotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Foto_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Image")
                        .HasColumnName("image")
                        .HasColumnType("image");

                    b.Property<int>("InterventieId")
                        .HasColumnName("Interventie_id");

                    b.HasKey("FotoId")
                        .HasName("PK__tmp_ms_x__729FCD7646B6130A");

                    b.HasIndex("InterventieId");

                    b.ToTable("Fotos");
                });

            modelBuilder.Entity("eindwerk.Entities.InterventieCompetenties", b =>
                {
                    b.Property<int>("InterventieId")
                        .HasColumnName("Interventie_id");

                    b.Property<int>("SpecialisatieId")
                        .HasColumnName("Specialisatie_id");

                    b.Property<int>("PersoneelsId")
                        .HasColumnName("Personeels_id");

                    b.HasKey("InterventieId", "SpecialisatieId", "PersoneelsId")
                        .HasName("PK__Interven__C34FE9FD08A23F7A");

                    b.HasIndex("PersoneelsId");

                    b.HasIndex("SpecialisatieId");

                    b.ToTable("Interventie competenties");
                });

            modelBuilder.Entity("eindwerk.Entities.Interventies", b =>
                {
                    b.Property<int>("InterventieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Interventie_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BestelId")
                        .HasColumnName("Bestel_id");

                    b.Property<string>("Complexiteit")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime?>("Duur")
                        .HasColumnName("duur")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Einddatum")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Meldingsdatum")
                        .HasColumnType("datetime");

                    b.Property<string>("Omschrijving")
                        .IsUnicode(false);

                    b.Property<string>("OmschrijvingOplossing")
                        .HasColumnName("Omschrijving oplossing")
                        .IsUnicode(false);

                    b.Property<int?>("PersoneelsId")
                        .HasColumnName("Personeels_id");

                    b.Property<int?>("PrioriteitId")
                        .HasColumnName("Prioriteit_id");

                    b.Property<string>("Status")
                        .HasColumnName("Soort interventie")
                        .HasMaxLength(50);

                    b.Property<int?>("ToestelId")
                        .HasColumnName("Toestel_id");

                    b.Property<DateTime?>("Verwachtteoplossingstermijn")
                        .HasColumnType("datetime");

                    b.HasKey("InterventieId")
                        .HasName("PK__tmp_ms_x__68723851FA4143A3");

                    b.HasIndex("BestelId");

                    b.HasIndex("PersoneelsId");

                    b.HasIndex("PrioriteitId");

                    b.HasIndex("ToestelId");

                    b.ToTable("Interventies");
                });

            modelBuilder.Entity("eindwerk.Entities.Kennisgebieden", b =>
                {
                    b.Property<int>("SpecialisatieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Specialisatie_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KorteOmschrijving")
                        .HasColumnName("Korte omschrijving")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("LangeOmschrijving")
                        .HasColumnName("Lange omschrijving")
                        .IsUnicode(false);

                    b.Property<string>("SoortKennisgebied")
                        .HasColumnName("Soort kennisgebied")
                        .HasMaxLength(10);

                    b.HasKey("SpecialisatieId")
                        .HasName("PK__tmp_ms_x__A25BAB2A13FCB8E7");

                    b.ToTable("Kennisgebieden");
                });

            modelBuilder.Entity("eindwerk.Entities.Leverancier", b =>
                {
                    b.Property<int>("LeveranciersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Leveranciers_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Huisnummer")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Naam")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Postcode")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Stad")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Straat")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Telefoon")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Website")
                        .IsUnicode(false);

                    b.HasKey("LeveranciersId")
                        .HasName("PK__tmp_ms_x__86F35737B1965161");

                    b.ToTable("Leverancier");
                });

            modelBuilder.Entity("eindwerk.Entities.Locatie", b =>
                {
                    b.Property<int>("LocatieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Locatie_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Oppervlakte")
                        .HasMaxLength(10);

                    b.Property<string>("SoortRuimte")
                        .HasColumnName("Soort Ruimte")
                        .HasMaxLength(10);

                    b.Property<string>("VoorraadPlaatsen")
                        .HasMaxLength(10);

                    b.HasKey("LocatieId");

                    b.ToTable("Locatie");
                });

            modelBuilder.Entity("eindwerk.Entities.Niveau", b =>
                {
                    b.Property<int>("NiveauId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Niveau_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Beginner")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Ervaren")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Expert")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("NiveauId");

                    b.ToTable("Niveau");
                });

            modelBuilder.Entity("eindwerk.Entities.Onderdelen", b =>
                {
                    b.Property<int>("ToestelId")
                        .HasColumnName("Toestel_id");

                    b.Property<int>("OnderdeelId")
                        .HasColumnName("Onderdeel_id");

                    b.Property<int?>("Formaat");

                    b.Property<int?>("Gewicht");

                    b.Property<string>("Kleur")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Omschrijving")
                        .IsUnicode(false);

                    b.Property<int?>("ParentonderdeelId")
                        .HasColumnName("Parentonderdeel_ID");

                    b.HasKey("ToestelId", "OnderdeelId")
                        .HasName("PK__Onderdel__DA156EBD7C3D2624");

                    b.ToTable("Onderdelen");
                });

            modelBuilder.Entity("eindwerk.Entities.Onderdelencode", b =>
                {
                    b.Property<int>("LeveranciersId")
                        .HasColumnName("Leveranciers_id");

                    b.Property<int>("OnderdeelId")
                        .HasColumnName("Onderdeel_id");

                    b.Property<int?>("Aankoopprijs");

                    b.Property<string>("OnderdelencodeLeverancier")
                        .HasColumnName("Onderdelencode_leverancier");

                    b.HasKey("LeveranciersId", "OnderdeelId")
                        .HasName("PK__Onderdel__C6194C2B479C3972");

                    b.ToTable("Onderdelencode");
                });

            modelBuilder.Entity("eindwerk.Entities.Personeelsleden", b =>
                {
                    b.Property<int>("PersoneelsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Personeels_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Emailadres");

                    b.Property<byte[]>("Foto")
                        .HasColumnType("image");

                    b.Property<string>("GsmNummer")
                        .HasColumnName("Gsm Nummer");

                    b.Property<string>("Naam")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("SoortPersoneelslid")
                        .HasColumnName("Soort Personeelslid")
                        .HasMaxLength(50);

                    b.Property<string>("Voornaam")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("PersoneelsId")
                        .HasName("PK__tmp_ms_x__186B1E10991444A9");

                    b.ToTable("Personeelsleden");
                });

            modelBuilder.Entity("eindwerk.Entities.Prioriteit", b =>
                {
                    b.Property<int>("PrioriteitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Prioriteit_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Dringend")
                        .HasMaxLength(10);

                    b.Property<string>("Gewoon")
                        .HasMaxLength(10);

                    b.Property<string>("HoogDringend")
                        .HasColumnName("Hoog Dringend")
                        .HasMaxLength(10);

                    b.Property<string>("ZeerDringen")
                        .HasColumnName("Zeer Dringen")
                        .HasMaxLength(10);

                    b.HasKey("PrioriteitId");

                    b.ToTable("Prioriteit");
                });

            modelBuilder.Entity("eindwerk.Entities.Tablet", b =>
                {
                    b.Property<int>("TabletId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Tablet_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BesturingsSysteeem")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Merk")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("Prijs");

                    b.Property<int?>("Resolutie");

                    b.Property<string>("SchermType")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("TabletId");

                    b.ToTable("Tablet");
                });

            modelBuilder.Entity("eindwerk.Entities.TabletPersoneelsLeden", b =>
                {
                    b.Property<int>("TabletId")
                        .HasColumnName("Tablet_id");

                    b.Property<int>("PersoneelsId")
                        .HasColumnName("Personeels_id");

                    b.HasKey("TabletId", "PersoneelsId")
                        .HasName("PK__TabletPe__7FF187720B2D43F7");

                    b.HasIndex("PersoneelsId");

                    b.ToTable("TabletPersoneelsLeden");
                });

            modelBuilder.Entity("eindwerk.Entities.Toestel", b =>
                {
                    b.Property<int>("ToestelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Toestel_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DatumAfschrijving")
                        .HasColumnType("datetime");

                    b.Property<int?>("Formaat");

                    b.Property<DateTime?>("Keuring")
                        .HasColumnType("datetime");

                    b.Property<int?>("LocatieId")
                        .HasColumnName("Locatie_id");

                    b.Property<string>("Materie")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("MaximumGewicht")
                        .HasColumnName("Maximum gewicht");

                    b.Property<string>("Merk")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Naam")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Omschrijving")
                        .IsUnicode(false);

                    b.Property<bool?>("Opplooibaar");

                    b.Property<int?>("Ouderdom");

                    b.Property<string>("SoortToestel")
                        .HasColumnName("Soort toestel")
                        .HasMaxLength(50);

                    b.Property<string>("TypeAandrijving")
                        .HasColumnName("Type aandrijving")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("TypeMatras")
                        .HasColumnName("Type matras")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<bool?>("Verstelbaar");

                    b.HasKey("ToestelId");

                    b.HasIndex("LocatieId");

                    b.ToTable("Toestel");
                });

            modelBuilder.Entity("eindwerk.Entities.Voorraad", b =>
                {
                    b.Property<int>("OnderdeelId")
                        .HasColumnName("Onderdeel_id");

                    b.Property<int>("LocatieId")
                        .HasColumnName("Locatie_id");

                    b.Property<int?>("Aantal");

                    b.HasKey("OnderdeelId", "LocatieId")
                        .HasName("PK__Voorraad__B50DF978AA0CFCC1");

                    b.ToTable("Voorraad");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eindwerk.Entities.Bestellingen", b =>
                {
                    b.HasOne("eindwerk.Entities.Facturen", "Factuur")
                        .WithMany("Bestellingen")
                        .HasForeignKey("FactuurId")
                        .HasConstraintName("FK_Bestellingen_Facturen");

                    b.HasOne("eindwerk.Entities.Interventies", "Interventie")
                        .WithMany("Bestellingen")
                        .HasForeignKey("InterventieId")
                        .HasConstraintName("FK_Bestellingen_Interventies");

                    b.HasOne("eindwerk.Entities.Leverancier", "Leveranciers")
                        .WithMany("Bestellingen")
                        .HasForeignKey("LeveranciersId")
                        .HasConstraintName("FK_Bestellingen_Leverancier");

                    b.HasOne("eindwerk.Entities.Personeelsleden", "Personeels")
                        .WithMany("Bestellingen")
                        .HasForeignKey("PersoneelsId")
                        .HasConstraintName("FK_Bestellingen_Personeelsleden");
                });

            modelBuilder.Entity("eindwerk.Entities.Competentie", b =>
                {
                    b.HasOne("eindwerk.Entities.Niveau", "NiveauNavigation")
                        .WithMany("Competentie")
                        .HasForeignKey("NiveauId")
                        .HasConstraintName("FK_Competentie_Niveau");
                });

            modelBuilder.Entity("eindwerk.Entities.Fotos", b =>
                {
                    b.HasOne("eindwerk.Entities.Interventies", "Interventie")
                        .WithMany("Fotos")
                        .HasForeignKey("InterventieId")
                        .HasConstraintName("FK_Fotos_Interventies");
                });

            modelBuilder.Entity("eindwerk.Entities.InterventieCompetenties", b =>
                {
                    b.HasOne("eindwerk.Entities.Interventies", "Interventie")
                        .WithMany("InterventieCompetenties")
                        .HasForeignKey("InterventieId")
                        .HasConstraintName("FK_Interventie competenties_Interventies");

                    b.HasOne("eindwerk.Entities.Personeelsleden", "Personeels")
                        .WithMany("InterventieCompetenties")
                        .HasForeignKey("PersoneelsId")
                        .HasConstraintName("FK_Interventie competenties_Personeelsleden");

                    b.HasOne("eindwerk.Entities.Kennisgebieden", "Specialisatie")
                        .WithMany("InterventieCompetenties")
                        .HasForeignKey("SpecialisatieId")
                        .HasConstraintName("FK_Interventie competenties_Kennisgebieden");
                });

            modelBuilder.Entity("eindwerk.Entities.Interventies", b =>
                {
                    b.HasOne("eindwerk.Entities.Bestellingen", "Bestel")
                        .WithMany("Interventies")
                        .HasForeignKey("BestelId")
                        .HasConstraintName("FK_Interventies_Bestellingen");

                    b.HasOne("eindwerk.Entities.Personeelsleden", "Personeels")
                        .WithMany("Interventies")
                        .HasForeignKey("PersoneelsId")
                        .HasConstraintName("FK_Interventies_Personeelsleden");

                    b.HasOne("eindwerk.Entities.Prioriteit", "Prioriteit")
                        .WithMany("Interventies")
                        .HasForeignKey("PrioriteitId")
                        .HasConstraintName("FK_Interventies_Prioriteit");

                    b.HasOne("eindwerk.Entities.Toestel", "Toestel")
                        .WithMany("Interventies")
                        .HasForeignKey("ToestelId")
                        .HasConstraintName("FK_Interventies_Toestel");
                });

            modelBuilder.Entity("eindwerk.Entities.Onderdelen", b =>
                {
                    b.HasOne("eindwerk.Entities.Toestel", "Toestel")
                        .WithMany("Onderdelen")
                        .HasForeignKey("ToestelId")
                        .HasConstraintName("FK_Onderdelen_Toestel");
                });

            modelBuilder.Entity("eindwerk.Entities.TabletPersoneelsLeden", b =>
                {
                    b.HasOne("eindwerk.Entities.Personeelsleden", "Personeels")
                        .WithMany("TabletPersoneelsLeden")
                        .HasForeignKey("PersoneelsId")
                        .HasConstraintName("FK_TabletPersoneelsLeden_Personeelsleden");

                    b.HasOne("eindwerk.Entities.Tablet", "Tablet")
                        .WithMany("TabletPersoneelsLeden")
                        .HasForeignKey("TabletId")
                        .HasConstraintName("FK_TabletPersoneelsLeden_Tablet");
                });

            modelBuilder.Entity("eindwerk.Entities.Toestel", b =>
                {
                    b.HasOne("eindwerk.Entities.Locatie", "Locatie")
                        .WithMany("Toestel")
                        .HasForeignKey("LocatieId")
                        .HasConstraintName("FK_Toestel_Locatie");
                });
#pragma warning restore 612, 618
        }
    }
}
