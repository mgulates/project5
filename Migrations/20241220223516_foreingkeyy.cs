using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project5.Migrations
{
    /// <inheritdoc />
    public partial class foreingkeyy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_ReviewerNameId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_ReviewerNameId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "ReviewerNameId",
                table: "Reviews");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_userID",
                table: "Reviews",
                column: "userID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_userID",
                table: "Reviews",
                column: "userID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_userID",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_userID",
                table: "Reviews");

            migrationBuilder.AddColumn<string>(
                name: "ReviewerNameId",
                table: "Reviews",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1L,
                column: "ReviewerNameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2L,
                column: "ReviewerNameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3L,
                column: "ReviewerNameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4L,
                column: "ReviewerNameId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewerNameId",
                table: "Reviews",
                column: "ReviewerNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_ReviewerNameId",
                table: "Reviews",
                column: "ReviewerNameId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
