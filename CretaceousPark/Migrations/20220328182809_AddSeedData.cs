using Microsoft.EntityFrameworkCore.Migrations;

namespace CretaceousPark.Solution.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Name", "Sex", "Species" },
                values: new object[,]
                {
                    { 1, 7, "Matilda", "Female", "Wooly Mammoth" },
                    { 2, 10, "Rexie", "Female", "Dinosaur" },
                    { 3, 2, "Matilda", "Female", "Dinosaur" },
                    { 4, 4, "Pip", "Male", "Shark" },
                    { 5, 22, "Bartholomew", "Male", "Dinosaur" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);
        }
    }
}
