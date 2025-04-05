using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComputerHardwares_HardwareDetails_HardwareDetailId",
                table: "ComputerHardwares");

            migrationBuilder.DropIndex(
                name: "IX_ComputerHardwares_HardwareDetailId",
                table: "ComputerHardwares");

            migrationBuilder.DropColumn(
                name: "HardwareDetailId",
                table: "ComputerHardwares");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HardwareDetailId",
                table: "ComputerHardwares",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ComputerHardwares_HardwareDetailId",
                table: "ComputerHardwares",
                column: "HardwareDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerHardwares_HardwareDetails_HardwareDetailId",
                table: "ComputerHardwares",
                column: "HardwareDetailId",
                principalTable: "HardwareDetails",
                principalColumn: "Id");
        }
    }
}
