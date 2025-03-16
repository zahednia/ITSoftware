using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class DownDataBAseKhone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hwd",
                table: "HardwareTypes");

            migrationBuilder.RenameColumn(
                name: "HwdTypeID",
                table: "Hardwares",
                newName: "HardwareTypeID");

            migrationBuilder.RenameColumn(
                name: "HwdDetailID",
                table: "Hardwares",
                newName: "HardwareDetailID");

            migrationBuilder.AddColumn<string>(
                name: "Hardware",
                table: "HardwareTypes",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hardware",
                table: "HardwareTypes");

            migrationBuilder.RenameColumn(
                name: "HardwareTypeID",
                table: "Hardwares",
                newName: "HwdTypeID");

            migrationBuilder.RenameColumn(
                name: "HardwareDetailID",
                table: "Hardwares",
                newName: "HwdDetailID");

            migrationBuilder.AddColumn<string>(
                name: "Hwd",
                table: "HardwareTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
