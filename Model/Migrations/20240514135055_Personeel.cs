using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class Personeel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personeel",
                columns: table => new
                {
                    PersoneelsNr = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Voornaam = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ManagerNr = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeel", x => x.PersoneelsNr);
                    table.ForeignKey(
                        name: "FK_Personeel_Personeel_ManagerNr",
                        column: x => x.ManagerNr,
                        principalTable: "Personeel",
                        principalColumn: "PersoneelsNr");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personeel_ManagerNr",
                table: "Personeel",
                column: "ManagerNr");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personeel");
        }
    }
}
