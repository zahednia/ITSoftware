using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateOn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                name: "ChMains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComputerId = table.Column<int>(type: "int", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChMains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChMains_Computers_ComputerId",
                        column: x => x.ComputerId,
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
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                name: "UserComputers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ComputerID = table.Column<int>(type: "int", nullable: false),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_UserComputers_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CheckLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChMainID = table.Column<int>(type: "int", nullable: false),
                    ChTypeID = table.Column<int>(type: "int", nullable: false),
                    ChStatusID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckLists_ChMains_ChMainID",
                        column: x => x.ChMainID,
                        principalTable: "ChMains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckLists_ChStatuses_ChStatusID",
                        column: x => x.ChStatusID,
                        principalTable: "ChStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckLists_ChTypes_ChTypeID",
                        column: x => x.ChTypeID,
                        principalTable: "ChTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HardwareDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HardwareTypeId = table.Column<int>(type: "int", nullable: false),
                    HardwareBrandId = table.Column<int>(type: "int", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                name: "Hardwares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HardwareTypeId = table.Column<int>(type: "int", nullable: false),
                    HardwareBrandId = table.Column<int>(type: "int", nullable: false),
                    HardwareDetailId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "ComputerHardwares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComputerId = table.Column<int>(type: "int", nullable: false),
                    HardwareId = table.Column<int>(type: "int", nullable: false),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                        name: "FK_ComputerHardwares_Hardwares_HardwareId",
                        column: x => x.HardwareId,
                        principalTable: "Hardwares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheckLists_ChMainID",
                table: "CheckLists",
                column: "ChMainID");

            migrationBuilder.CreateIndex(
                name: "IX_CheckLists_ChStatusID",
                table: "CheckLists",
                column: "ChStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_CheckLists_ChTypeID",
                table: "CheckLists",
                column: "ChTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ChMains_ComputerId",
                table: "ChMains",
                column: "ComputerId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerHardwares_ComputerId",
                table: "ComputerHardwares",
                column: "ComputerId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerHardwares_HardwareId",
                table: "ComputerHardwares",
                column: "HardwareId");

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

            migrationBuilder.CreateIndex(
                name: "IX_UserComputers_UserID",
                table: "UserComputers",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckLists");

            migrationBuilder.DropTable(
                name: "ComputerHardwares");

            migrationBuilder.DropTable(
                name: "UserComputers");

            migrationBuilder.DropTable(
                name: "ChMains");

            migrationBuilder.DropTable(
                name: "ChStatuses");

            migrationBuilder.DropTable(
                name: "ChTypes");

            migrationBuilder.DropTable(
                name: "Hardwares");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.DropTable(
                name: "HardwareDetails");

            migrationBuilder.DropTable(
                name: "HardwareBrands");

            migrationBuilder.DropTable(
                name: "HardwareTypes");
        }
    }
}
