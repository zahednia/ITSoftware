using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class DataBaseUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HardwareType",
                table: "HardwareBrands");

            migrationBuilder.RenameColumn(
                name: "HardwareTypeID",
                table: "Hardwares",
                newName: "HardwareModelID");

            migrationBuilder.RenameColumn(
                name: "HardwareDetailID",
                table: "Hardwares",
                newName: "HardwareBrandID");

            migrationBuilder.AddColumn<int>(
                name: "HardwareTypeID",
                table: "HardwareBrands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "HardwareTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardwareTypes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HardwareTypes");

            migrationBuilder.DropColumn(
                name: "HardwareTypeID",
                table: "HardwareBrands");

            migrationBuilder.RenameColumn(
                name: "HardwareModelID",
                table: "Hardwares",
                newName: "HardwareTypeID");

            migrationBuilder.RenameColumn(
                name: "HardwareBrandID",
                table: "Hardwares",
                newName: "HardwareDetailID");

            migrationBuilder.AddColumn<string>(
                name: "HardwareType",
                table: "HardwareBrands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
