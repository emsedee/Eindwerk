using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eindwerk.Migrations
{
    public partial class CreateIdentitySchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bestelde onderdelen",
                columns: table => new
                {
                    Bestel_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Onderdeel_id = table.Column<int>(nullable: false),
                    Onderdelencode_leverancier = table.Column<string>(unicode: false, nullable: true),
                    Aantal = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tmp_ms_x__EA0C1B679AED5673", x => new { x.Onderdeel_id, x.Bestel_id });
                });

            migrationBuilder.CreateTable(
                name: "Betrokkenheid",
                columns: table => new
                {
                    Interventie_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Personeels_id = table.Column<int>(nullable: false),
                    Begin = table.Column<DateTime>(type: "datetime", nullable: true),
                    Einde = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tmp_ms_x__79F489B0893BB803", x => new { x.Interventie_id, x.Personeels_id });
                });

            migrationBuilder.CreateTable(
                name: "Facturen",
                columns: table => new
                {
                    Factuur_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: true),
                    VervalDatum = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tmp_ms_x__C70C0B1C87BB52CC", x => x.Factuur_id);
                });

            migrationBuilder.CreateTable(
                name: "Kennisgebieden",
                columns: table => new
                {
                    Specialisatie_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Korteomschrijving = table.Column<string>(name: "Korte omschrijving", unicode: false, maxLength: 50, nullable: true),
                    Langeomschrijving = table.Column<string>(name: "Lange omschrijving", unicode: false, nullable: true),
                    Soortkennisgebied = table.Column<string>(name: "Soort kennisgebied", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tmp_ms_x__A25BAB2A13FCB8E7", x => x.Specialisatie_id);
                });

            migrationBuilder.CreateTable(
                name: "Leverancier",
                columns: table => new
                {
                    Leveranciers_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Telefoon = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Website = table.Column<string>(unicode: false, nullable: true),
                    Straat = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Huisnummer = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Postcode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Stad = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tmp_ms_x__86F35737B1965161", x => x.Leveranciers_id);
                });

            migrationBuilder.CreateTable(
                name: "Locatie",
                columns: table => new
                {
                    Locatie_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VoorraadPlaatsen = table.Column<string>(maxLength: 10, nullable: true),
                    Oppervlakte = table.Column<string>(maxLength: 10, nullable: true),
                    SoortRuimte = table.Column<string>(name: "Soort Ruimte", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locatie", x => x.Locatie_id);
                });

            migrationBuilder.CreateTable(
                name: "Niveau",
                columns: table => new
                {
                    Niveau_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Beginner = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Ervaren = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Expert = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Niveau", x => x.Niveau_id);
                });

            migrationBuilder.CreateTable(
                name: "Onderdelencode",
                columns: table => new
                {
                    Leveranciers_id = table.Column<int>(nullable: false),
                    Onderdeel_id = table.Column<int>(nullable: false),
                    Onderdelencode_leverancier = table.Column<string>(nullable: true),
                    Aankoopprijs = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Onderdel__C6194C2B479C3972", x => new { x.Leveranciers_id, x.Onderdeel_id });
                });

            migrationBuilder.CreateTable(
                name: "Personeelsleden",
                columns: table => new
                {
                    Personeels_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Voornaam = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    GsmNummer = table.Column<string>(name: "Gsm Nummer", nullable: true),
                    Emailadres = table.Column<string>(nullable: true),
                    Foto = table.Column<byte[]>(type: "image", nullable: true),
                    SoortPersoneelslid = table.Column<string>(name: "Soort Personeelslid", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tmp_ms_x__186B1E10991444A9", x => x.Personeels_id);
                });

            migrationBuilder.CreateTable(
                name: "Prioriteit",
                columns: table => new
                {
                    Prioriteit_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Gewoon = table.Column<string>(maxLength: 10, nullable: true),
                    Dringend = table.Column<string>(maxLength: 10, nullable: true),
                    ZeerDringen = table.Column<string>(name: "Zeer Dringen", maxLength: 10, nullable: true),
                    HoogDringend = table.Column<string>(name: "Hoog Dringend", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prioriteit", x => x.Prioriteit_id);
                });

            migrationBuilder.CreateTable(
                name: "Tablet",
                columns: table => new
                {
                    Tablet_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Prijs = table.Column<int>(nullable: true),
                    Merk = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    BesturingsSysteeem = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    SchermType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Resolutie = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tablet", x => x.Tablet_id);
                });

            migrationBuilder.CreateTable(
                name: "Voorraad",
                columns: table => new
                {
                    Onderdeel_id = table.Column<int>(nullable: false),
                    Locatie_id = table.Column<int>(nullable: false),
                    Aantal = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Voorraad__B50DF978AA0CFCC1", x => new { x.Onderdeel_id, x.Locatie_id });
                });

            migrationBuilder.CreateTable(
                name: "Toestel",
                columns: table => new
                {
                    Toestel_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Merk = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Keuring = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ouderdom = table.Column<int>(nullable: true),
                    Omschrijving = table.Column<string>(unicode: false, nullable: true),
                    Formaat = table.Column<int>(nullable: true),
                    Maximumgewicht = table.Column<int>(name: "Maximum gewicht", nullable: true),
                    Typematras = table.Column<string>(name: "Type matras", unicode: false, maxLength: 50, nullable: true),
                    Typeaandrijving = table.Column<string>(name: "Type aandrijving", unicode: false, maxLength: 50, nullable: true),
                    Opplooibaar = table.Column<bool>(nullable: true),
                    Verstelbaar = table.Column<bool>(nullable: true),
                    Materie = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DatumAfschrijving = table.Column<DateTime>(type: "datetime", nullable: true),
                    Locatie_id = table.Column<int>(nullable: true),
                    Soorttoestel = table.Column<string>(name: "Soort toestel", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toestel", x => x.Toestel_id);
                    table.ForeignKey(
                        name: "FK_Toestel_Locatie",
                        column: x => x.Locatie_id,
                        principalTable: "Locatie",
                        principalColumn: "Locatie_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Competentie",
                columns: table => new
                {
                    Personeels_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Specialisatie_id = table.Column<int>(nullable: false),
                    Niveau = table.Column<string>(maxLength: 10, nullable: true),
                    Niveau_id = table.Column<int>(nullable: true),
                    Datumverworven = table.Column<DateTime>(name: "Datum verworven", type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tmp_ms_x__A24EA4A2DD4B802B", x => new { x.Personeels_id, x.Specialisatie_id });
                    table.ForeignKey(
                        name: "FK_Competentie_Niveau",
                        column: x => x.Niveau_id,
                        principalTable: "Niveau",
                        principalColumn: "Niveau_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TabletPersoneelsLeden",
                columns: table => new
                {
                    Tablet_id = table.Column<int>(nullable: false),
                    Personeels_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TabletPe__7FF187720B2D43F7", x => new { x.Tablet_id, x.Personeels_id });
                    table.ForeignKey(
                        name: "FK_TabletPersoneelsLeden_Personeelsleden",
                        column: x => x.Personeels_id,
                        principalTable: "Personeelsleden",
                        principalColumn: "Personeels_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TabletPersoneelsLeden_Tablet",
                        column: x => x.Tablet_id,
                        principalTable: "Tablet",
                        principalColumn: "Tablet_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Onderdelen",
                columns: table => new
                {
                    Toestel_id = table.Column<int>(nullable: false),
                    Onderdeel_id = table.Column<int>(nullable: false),
                    Kleur = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Omschrijving = table.Column<string>(unicode: false, nullable: true),
                    Formaat = table.Column<int>(nullable: true),
                    Gewicht = table.Column<int>(nullable: true),
                    Parentonderdeel_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Onderdel__DA156EBD7C3D2624", x => new { x.Toestel_id, x.Onderdeel_id });
                    table.ForeignKey(
                        name: "FK_Onderdelen_Toestel",
                        column: x => x.Toestel_id,
                        principalTable: "Toestel",
                        principalColumn: "Toestel_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Interventies",
                columns: table => new
                {
                    Interventie_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Complexiteit = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Meldingsdatum = table.Column<DateTime>(type: "datetime", nullable: true),
                    Omschrijving = table.Column<string>(unicode: false, nullable: true),
                    Einddatum = table.Column<DateTime>(type: "datetime", nullable: true),
                    duur = table.Column<DateTime>(type: "datetime", nullable: true),
                    Verwachtteoplossingstermijn = table.Column<DateTime>(type: "datetime", nullable: true),
                    Omschrijvingoplossing = table.Column<string>(name: "Omschrijving oplossing", unicode: false, nullable: true),
                    Personeels_id = table.Column<int>(nullable: true),
                    Prioriteit_id = table.Column<int>(nullable: true),
                    Toestel_id = table.Column<int>(nullable: true),
                    Bestel_id = table.Column<int>(nullable: true),
                    Soortinterventie = table.Column<string>(name: "Soort interventie", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tmp_ms_x__68723851FA4143A3", x => x.Interventie_id);
                    table.ForeignKey(
                        name: "FK_Interventies_Personeelsleden",
                        column: x => x.Personeels_id,
                        principalTable: "Personeelsleden",
                        principalColumn: "Personeels_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Interventies_Prioriteit",
                        column: x => x.Prioriteit_id,
                        principalTable: "Prioriteit",
                        principalColumn: "Prioriteit_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Interventies_Toestel",
                        column: x => x.Toestel_id,
                        principalTable: "Toestel",
                        principalColumn: "Toestel_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bestellingen",
                columns: table => new
                {
                    Bestel_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Besteldatum = table.Column<string>(maxLength: 10, nullable: true),
                    LeveringsDatum = table.Column<string>(maxLength: 10, nullable: true),
                    Leveranciers_id = table.Column<int>(nullable: false),
                    Personeels_id = table.Column<int>(nullable: false),
                    Factuur_id = table.Column<int>(nullable: false),
                    Interventie_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Bestelli__4ADAAA2FF29D6105", x => x.Bestel_id);
                    table.ForeignKey(
                        name: "FK_Bestellingen_Facturen",
                        column: x => x.Factuur_id,
                        principalTable: "Facturen",
                        principalColumn: "Factuur_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bestellingen_Interventies",
                        column: x => x.Interventie_id,
                        principalTable: "Interventies",
                        principalColumn: "Interventie_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bestellingen_Leverancier",
                        column: x => x.Leveranciers_id,
                        principalTable: "Leverancier",
                        principalColumn: "Leveranciers_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bestellingen_Personeelsleden",
                        column: x => x.Personeels_id,
                        principalTable: "Personeelsleden",
                        principalColumn: "Personeels_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fotos",
                columns: table => new
                {
                    Foto_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Interventie_id = table.Column<int>(nullable: false),
                    image = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tmp_ms_x__729FCD7646B6130A", x => x.Foto_id);
                    table.ForeignKey(
                        name: "FK_Fotos_Interventies",
                        column: x => x.Interventie_id,
                        principalTable: "Interventies",
                        principalColumn: "Interventie_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Interventie competenties",
                columns: table => new
                {
                    Interventie_id = table.Column<int>(nullable: false),
                    Personeels_id = table.Column<int>(nullable: false),
                    Specialisatie_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Interven__C34FE9FD08A23F7A", x => new { x.Interventie_id, x.Specialisatie_id, x.Personeels_id });
                    table.ForeignKey(
                        name: "FK_Interventie competenties_Interventies",
                        column: x => x.Interventie_id,
                        principalTable: "Interventies",
                        principalColumn: "Interventie_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Interventie competenties_Personeelsleden",
                        column: x => x.Personeels_id,
                        principalTable: "Personeelsleden",
                        principalColumn: "Personeels_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Interventie competenties_Kennisgebieden",
                        column: x => x.Specialisatie_id,
                        principalTable: "Kennisgebieden",
                        principalColumn: "Specialisatie_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bestellingen_Factuur_id",
                table: "Bestellingen",
                column: "Factuur_id");

            migrationBuilder.CreateIndex(
                name: "IX_Bestellingen_Interventie_id",
                table: "Bestellingen",
                column: "Interventie_id");

            migrationBuilder.CreateIndex(
                name: "IX_Bestellingen_Leveranciers_id",
                table: "Bestellingen",
                column: "Leveranciers_id");

            migrationBuilder.CreateIndex(
                name: "IX_Bestellingen_Personeels_id",
                table: "Bestellingen",
                column: "Personeels_id");

            migrationBuilder.CreateIndex(
                name: "IX_Competentie_Niveau_id",
                table: "Competentie",
                column: "Niveau_id");

            migrationBuilder.CreateIndex(
                name: "IX_Fotos_Interventie_id",
                table: "Fotos",
                column: "Interventie_id");

            migrationBuilder.CreateIndex(
                name: "IX_Interventie competenties_Personeels_id",
                table: "Interventie competenties",
                column: "Personeels_id");

            migrationBuilder.CreateIndex(
                name: "IX_Interventie competenties_Specialisatie_id",
                table: "Interventie competenties",
                column: "Specialisatie_id");

            migrationBuilder.CreateIndex(
                name: "IX_Interventies_Bestel_id",
                table: "Interventies",
                column: "Bestel_id");

            migrationBuilder.CreateIndex(
                name: "IX_Interventies_Personeels_id",
                table: "Interventies",
                column: "Personeels_id");

            migrationBuilder.CreateIndex(
                name: "IX_Interventies_Prioriteit_id",
                table: "Interventies",
                column: "Prioriteit_id");

            migrationBuilder.CreateIndex(
                name: "IX_Interventies_Toestel_id",
                table: "Interventies",
                column: "Toestel_id");

            migrationBuilder.CreateIndex(
                name: "IX_TabletPersoneelsLeden_Personeels_id",
                table: "TabletPersoneelsLeden",
                column: "Personeels_id");

            migrationBuilder.CreateIndex(
                name: "IX_Toestel_Locatie_id",
                table: "Toestel",
                column: "Locatie_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Interventies_Bestellingen",
                table: "Interventies",
                column: "Bestel_id",
                principalTable: "Bestellingen",
                principalColumn: "Bestel_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bestellingen_Facturen",
                table: "Bestellingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Bestellingen_Interventies",
                table: "Bestellingen");

            migrationBuilder.DropTable(
                name: "Bestelde onderdelen");

            migrationBuilder.DropTable(
                name: "Betrokkenheid");

            migrationBuilder.DropTable(
                name: "Competentie");

            migrationBuilder.DropTable(
                name: "Fotos");

            migrationBuilder.DropTable(
                name: "Interventie competenties");

            migrationBuilder.DropTable(
                name: "Onderdelen");

            migrationBuilder.DropTable(
                name: "Onderdelencode");

            migrationBuilder.DropTable(
                name: "TabletPersoneelsLeden");

            migrationBuilder.DropTable(
                name: "Voorraad");

            migrationBuilder.DropTable(
                name: "Niveau");

            migrationBuilder.DropTable(
                name: "Kennisgebieden");

            migrationBuilder.DropTable(
                name: "Tablet");

            migrationBuilder.DropTable(
                name: "Facturen");

            migrationBuilder.DropTable(
                name: "Interventies");

            migrationBuilder.DropTable(
                name: "Bestellingen");

            migrationBuilder.DropTable(
                name: "Prioriteit");

            migrationBuilder.DropTable(
                name: "Toestel");

            migrationBuilder.DropTable(
                name: "Leverancier");

            migrationBuilder.DropTable(
                name: "Personeelsleden");

            migrationBuilder.DropTable(
                name: "Locatie");
        }
    }
}
