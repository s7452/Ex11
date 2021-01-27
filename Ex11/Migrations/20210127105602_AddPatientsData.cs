using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ex11.Migrations
{
    public partial class AddPatientsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "IdPatient", "Birthdate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1995, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dariusz", "Nowakowski" },
                    { 2, new DateTime(1990, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Halina", "Nowak" },
                    { 3, new DateTime(2000, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrycja", "Kowal" },
                    { 4, new DateTime(2000, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wojciech", "Piotrowski" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 4);
        }
    }
}
