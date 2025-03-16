using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class updatedatasss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Computers_ComputerId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ComputerId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ComputerId",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComputerId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_ComputerId",
                table: "Users",
                column: "ComputerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Computers_ComputerId",
                table: "Users",
                column: "ComputerId",
                principalTable: "Computers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
