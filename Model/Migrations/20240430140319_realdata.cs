using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class realdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Klanten",
                columns: table => new
                {
                    KlantNr = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Voornaam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klanten", x => x.KlantNr);
                });

            migrationBuilder.CreateTable(
                name: "Rekeningen",
                columns: table => new
                {
                    RekeningNr = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Saldo = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Soort = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    KlantNr = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rekeningen", x => x.RekeningNr);
                    table.ForeignKey(
                        name: "FK_Rekeningen_Klanten_KlantNr",
                        column: x => x.KlantNr,
                        principalTable: "Klanten",
                        principalColumn: "KlantNr",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Klanten",
                columns: new[] { "KlantNr", "Voornaam" },
                values: new object[,]
                {
                    { 1, "Marge" },
                    { 2, "Homer" },
                    { 3, "Lisa" },
                    { 4, "Maggie" },
                    { 5, "Bart" }
                });

            migrationBuilder.InsertData(
                table: "Rekeningen",
                columns: new[] { "RekeningNr", "KlantNr", "Saldo", "Soort" },
                values: new object[,]
                {
                    { "123-4567890-02", 1, 1000m, "Z" },
                    { "234-5678901-69", 1, 2000m, "S" },
                    { "345-6789012-12", 2, 500m, "S" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rekeningen_KlantNr",
                table: "Rekeningen",
                column: "KlantNr");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rekeningen");

            migrationBuilder.DropTable(
                name: "Klanten");
        }
    }
}
