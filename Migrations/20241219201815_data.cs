using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace project5.Migrations
{
    /// <inheritdoc />
    public partial class data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ContentCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryID",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "ContentCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryID",
                value: 2L);

            migrationBuilder.InsertData(
                table: "ContentCategories",
                columns: new[] { "Id", "CategoryID", "ContentID" },
                values: new object[,]
                {
                    { 36, 1L, 1 },
                    { 37, 2L, 1 },
                    { 38, 1L, 2 },
                    { 39, 2L, 2 },
                    { 40, 1L, 3 },
                    { 41, 3L, 3 },
                    { 42, 1L, 4 },
                    { 43, 4L, 4 },
                    { 44, 1L, 5 },
                    { 45, 2L, 5 },
                    { 46, 5L, 6 },
                    { 47, 6L, 6 },
                    { 48, 8L, 8 },
                    { 49, 7L, 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContentCategories",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ContentCategories",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ContentCategories",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ContentCategories",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ContentCategories",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ContentCategories",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ContentCategories",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ContentCategories",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ContentCategories",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ContentCategories",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ContentCategories",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ContentCategories",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ContentCategories",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ContentCategories",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.UpdateData(
                table: "ContentCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryID",
                value: 8L);

            migrationBuilder.UpdateData(
                table: "ContentCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryID",
                value: 7L);
        }
    }
}
