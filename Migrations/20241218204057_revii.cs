using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project5.Migrations
{
    /// <inheritdoc />
    public partial class revii : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "contentID",
                table: "Reviews",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1L,
                column: "contentID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2L,
                column: "contentID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3L,
                column: "contentID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4L,
                column: "contentID",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_contentID",
                table: "Reviews",
                column: "contentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Content_contentID",
                table: "Reviews",
                column: "contentID",
                principalTable: "Content",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Content_contentID",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_contentID",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "contentID",
                table: "Reviews");
        }
    }
}
