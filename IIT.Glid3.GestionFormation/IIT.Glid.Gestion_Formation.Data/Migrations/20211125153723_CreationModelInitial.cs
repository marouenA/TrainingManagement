using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IIT.Glid.Gestion_Formation.Data.Migrations
{
    public partial class CreationModelInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Formateur",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(type: "TEXT", nullable: true),
                    Prenom = table.Column<string>(type: "TEXT", nullable: true),
                    Telephone = table.Column<string>(type: "TEXT", nullable: true),
                    Adresse = table.Column<string>(type: "TEXT", nullable: true),
                    Couts = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formateur", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Voitures",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Matricule = table.Column<string>(type: "TEXT", nullable: true),
                    Marque = table.Column<string>(type: "TEXT", nullable: true),
                    Modele = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voitures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Formation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Sujet = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Duree = table.Column<int>(type: "INTEGER", nullable: false),
                    Frais = table.Column<float>(type: "REAL", nullable: false),
                    FormateurID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formation", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Formation_Formateur_FormateurID",
                        column: x => x.FormateurID,
                        principalTable: "Formateur",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Etudiant",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(type: "TEXT", nullable: true),
                    Prenom = table.Column<string>(type: "TEXT", nullable: true),
                    Telephone = table.Column<string>(type: "TEXT", nullable: true),
                    DateInscription = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Payement = table.Column<bool>(type: "INTEGER", nullable: false),
                    FormationID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etudiant", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Etudiant_Formation_FormationID",
                        column: x => x.FormationID,
                        principalTable: "Formation",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Etudiant",
                columns: new[] { "ID", "DateInscription", "FormationID", "Nom", "Payement", "Prenom", "Telephone" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ali", true, "aydi", "112233" });

            migrationBuilder.InsertData(
                table: "Voitures",
                columns: new[] { "Id", "Marque", "Matricule", "Modele" },
                values: new object[] { 1L, "Polo", "128 TN 1589", "6" });

            migrationBuilder.InsertData(
                table: "Voitures",
                columns: new[] { "Id", "Marque", "Matricule", "Modele" },
                values: new object[] { 2L, "Polo", "128 TN 1589", "6" });

            migrationBuilder.CreateIndex(
                name: "IX_Etudiant_FormationID",
                table: "Etudiant",
                column: "FormationID");

            migrationBuilder.CreateIndex(
                name: "IX_Formation_FormateurID",
                table: "Formation",
                column: "FormateurID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Etudiant");

            migrationBuilder.DropTable(
                name: "Voitures");

            migrationBuilder.DropTable(
                name: "Formation");

            migrationBuilder.DropTable(
                name: "Formateur");
        }
    }
}
