using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Make_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComputerId",
                table: "Timesheets",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Timesheets_ComputerId",
                table: "Timesheets",
                column: "ComputerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Timesheets_Computers_ComputerId",
                table: "Timesheets",
                column: "ComputerId",
                principalTable: "Computers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Timesheets_Computers_ComputerId",
                table: "Timesheets");

            migrationBuilder.DropIndex(
                name: "IX_Timesheets_ComputerId",
                table: "Timesheets");

            migrationBuilder.DropColumn(
                name: "ComputerId",
                table: "Timesheets");
        }
    }
}
