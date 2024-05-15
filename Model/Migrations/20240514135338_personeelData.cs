using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class personeelData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Personeel",
                columns: new[] { "PersoneelsNr", "ManagerNr", "Voornaam" },
                values: new object[,]
                {
                    { 1, null, "Diane" },
                    { 2, 1, "Mary" },
                    { 3, 1, "Jeff" },
                    { 4, 2, "William" },
                    { 5, 2, "Gerard" },
                    { 6, 2, "Anthony" },
                    { 19, 2, "Mami" },
                    { 7, 6, "Leslie" },
                    { 8, 6, "July" },
                    { 9, 6, "Steve" },
                    { 10, 6, "Foon Yue" },
                    { 11, 6, "George" },
                    { 12, 5, "Louj" },
                    { 13, 5, "Pamela" },
                    { 14, 5, "Larry" },
                    { 15, 5, "Barry" },
                    { 16, 4, "Any" },
                    { 17, 4, "Peter" },
                    { 18, 4, "Tom" },
                    { 20, 19, "Yoshimi" },
                    { 21, 5, "Matin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Personeel",
                keyColumn: "PersoneelsNr",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Personeel",
                keyColumn: "PersoneelsNr",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Personeel",
                keyColumn: "PersoneelsNr",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Personeel",
                keyColumn: "PersoneelsNr",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Personeel",
                keyColumn: "PersoneelsNr",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Personeel",
                keyColumn: "PersoneelsNr",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Personeel",
                keyColumn: "PersoneelsNr",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Personeel",
                keyColumn: "PersoneelsNr",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Personeel",
                keyColumn: "PersoneelsNr",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Personeel",
                keyColumn: "PersoneelsNr",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Personeel",
                keyColumn: "PersoneelsNr",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Personeel",
                keyColumn: "PersoneelsNr",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Personeel",
                keyColumn: "PersoneelsNr",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Personeel",
                keyColumn: "PersoneelsNr",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Personeel",
                keyColumn: "PersoneelsNr",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Personeel",
                keyColumn: "PersoneelsNr",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Personeel",
                keyColumn: "PersoneelsNr",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Personeel",
                keyColumn: "PersoneelsNr",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Personeel",
                keyColumn: "PersoneelsNr",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Personeel",
                keyColumn: "PersoneelsNr",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Personeel",
                keyColumn: "PersoneelsNr",
                keyValue: 1);
        }
    }
}
