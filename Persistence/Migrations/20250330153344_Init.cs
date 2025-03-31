using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserComputers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ComputerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserComputers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserComputers_Computers_ComputerID",
                        column: x => x.ComputerID,
                        principalTable: "Computers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HardwareBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HardwareTypeId = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardwareBrands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HardwareBrands_HardwareTypes_HardwareTypeId",
                        column: x => x.HardwareTypeId,
                        principalTable: "HardwareTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HardwareDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HardwareTypeId = table.Column<int>(type: "int", nullable: false),
                    HardwareBrandId = table.Column<int>(type: "int", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardwareDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HardwareDetails_HardwareBrands_HardwareBrandId",
                        column: x => x.HardwareBrandId,
                        principalTable: "HardwareBrands",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HardwareDetails_HardwareTypes_HardwareTypeId",
                        column: x => x.HardwareTypeId,
                        principalTable: "HardwareTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ComputerHardwares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComputerId = table.Column<int>(type: "int", nullable: false),
                    HardwareDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerHardwares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComputerHardwares_Computers_ComputerId",
                        column: x => x.ComputerId,
                        principalTable: "Computers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComputerHardwares_HardwareDetails_HardwareDetailId",
                        column: x => x.HardwareDetailId,
                        principalTable: "HardwareDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hardwares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HardwareDetailId = table.Column<int>(type: "int", nullable: false),
                    HardwareTypeId = table.Column<int>(type: "int", nullable: false),
                    HardwareBrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hardwares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hardwares_HardwareBrands_HardwareBrandId",
                        column: x => x.HardwareBrandId,
                        principalTable: "HardwareBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hardwares_HardwareDetails_HardwareDetailId",
                        column: x => x.HardwareDetailId,
                        principalTable: "HardwareDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hardwares_HardwareTypes_HardwareTypeId",
                        column: x => x.HardwareTypeId,
                        principalTable: "HardwareTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComputerHardwares_ComputerId",
                table: "ComputerHardwares",
                column: "ComputerId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerHardwares_HardwareDetailId",
                table: "ComputerHardwares",
                column: "HardwareDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareBrands_HardwareTypeId",
                table: "HardwareBrands",
                column: "HardwareTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareDetails_HardwareBrandId",
                table: "HardwareDetails",
                column: "HardwareBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareDetails_HardwareTypeId",
                table: "HardwareDetails",
                column: "HardwareTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Hardwares_HardwareBrandId",
                table: "Hardwares",
                column: "HardwareBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Hardwares_HardwareDetailId",
                table: "Hardwares",
                column: "HardwareDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Hardwares_HardwareTypeId",
                table: "Hardwares",
                column: "HardwareTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComputers_ComputerID",
                table: "UserComputers",
                column: "ComputerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComputerHardwares");

            migrationBuilder.DropTable(
                name: "Hardwares");

            migrationBuilder.DropTable(
                name: "UserComputers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "HardwareDetails");

            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.DropTable(
                name: "HardwareBrands");

            migrationBuilder.DropTable(
                name: "HardwareTypes");
        }
    }
}
