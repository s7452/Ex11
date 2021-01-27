using Microsoft.EntityFrameworkCore.Migrations;

namespace Ex11.Migrations
{
    public partial class AddMedicamentsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Medicament",
                columns: new[] { "IdMedicament", "Descrition", "Name", "Type" },
                values: new object[] { 1, "Przykładowy opis Apap", "APAP", "Przeciwbólowy" });

            migrationBuilder.InsertData(
                table: "Medicament",
                columns: new[] { "IdMedicament", "Descrition", "Name", "Type" },
                values: new object[] { 2, "Przykładowy opis Ibuprom", "Ibuprom", "Przeciwbólowy" });

            migrationBuilder.InsertData(
                table: "Medicament",
                columns: new[] { "IdMedicament", "Descrition", "Name", "Type" },
                values: new object[] { 3, "Przykładowy opis Sayropexu", "Syropex", "Syrop na kaszel" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 3);
        }
    }
}
