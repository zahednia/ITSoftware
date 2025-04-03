using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddUserNavigationOnComputer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UserComputers_UserID",
                table: "UserComputers",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserComputers_Users_UserID",
                table: "UserComputers",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserComputers_Users_UserID",
                table: "UserComputers");

            migrationBuilder.DropIndex(
                name: "IX_UserComputers_UserID",
                table: "UserComputers");
        }
    }
}
