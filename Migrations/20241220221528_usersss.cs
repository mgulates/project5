using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project5.Migrations
{
    /// <inheritdoc />
    public partial class usersss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReviewerName",
                table: "Reviews",
                newName: "userID");

            migrationBuilder.AddColumn<string>(
                name: "ReviewerNameId",
                table: "Reviews",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1L,
                columns: new[] { "ReviewerNameId", "userID" },
                values: new object[] { null, "628d9b3b-722c-49c0-9c73-888fcc1f86e7" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2L,
                columns: new[] { "ReviewerNameId", "userID" },
                values: new object[] { null, "628d9b3b-722c-49c0-9c73-888fcc1f86e7" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3L,
                columns: new[] { "ReviewerNameId", "userID" },
                values: new object[] { null, "628d9b3b-722c-49c0-9c73-888fcc1f86e7" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4L,
                columns: new[] { "ReviewerNameId", "userID" },
                values: new object[] { null, "628d9b3b-722c-49c0-9c73-888fcc1f86e7" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "userID",
                table: "Reviews",
                newName: "ReviewerName");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1L,
                column: "ReviewerName",
                value: "Test");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2L,
                column: "ReviewerName",
                value: "Test1");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3L,
                column: "ReviewerName",
                value: "Test2");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4L,
                column: "ReviewerName",
                value: "Test3");
        }
    }
}
