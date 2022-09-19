using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkingSystem_API.Migrations
{
    public partial class multipletable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "parkingDetails",
                columns: table => new
                {
                    FloorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Slot1 = table.Column<bool>(type: "bit", nullable: false),
                    Slot2 = table.Column<bool>(type: "bit", nullable: false),
                    Slot3 = table.Column<bool>(type: "bit", nullable: false),
                    Slot4 = table.Column<bool>(type: "bit", nullable: false),
                    Slot5 = table.Column<bool>(type: "bit", nullable: false),
                    Slot6 = table.Column<bool>(type: "bit", nullable: false),
                    Slot7 = table.Column<bool>(type: "bit", nullable: false),
                    Slot8 = table.Column<bool>(type: "bit", nullable: false),
                    Slot9 = table.Column<bool>(type: "bit", nullable: false),
                    Slot10 = table.Column<bool>(type: "bit", nullable: false),
                    Slot11 = table.Column<bool>(type: "bit", nullable: false),
                    Slot12 = table.Column<bool>(type: "bit", nullable: false),
                    Slot13 = table.Column<bool>(type: "bit", nullable: false),
                    Slot14 = table.Column<bool>(type: "bit", nullable: false),
                    Slot15 = table.Column<bool>(type: "bit", nullable: false),
                    Slot16 = table.Column<bool>(type: "bit", nullable: false),
                    Slot17 = table.Column<bool>(type: "bit", nullable: false),
                    Slot18 = table.Column<bool>(type: "bit", nullable: false),
                    Slot19 = table.Column<bool>(type: "bit", nullable: false),
                    Slot20 = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parkingDetails", x => x.FloorId);
                });

            migrationBuilder.CreateTable(
                name: "parkingSummaries",
                columns: table => new
                {
                    ZoneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZoneTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalSlots = table.Column<int>(type: "int", nullable: false),
                    FilledSlots = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parkingSummaries", x => x.ZoneId);
                });

            migrationBuilder.CreateTable(
                name: "vehicleDbModels",
                columns: table => new
                {
                    Vehicle_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    Owner_Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Vehicle_Number = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FloorId = table.Column<int>(type: "int", nullable: false),
                    SlotId = table.Column<int>(type: "int", nullable: false),
                    ParkingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnparkingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParkingPin = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicleDbModels", x => x.Vehicle_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "parkingDetails");

            migrationBuilder.DropTable(
                name: "parkingSummaries");

            migrationBuilder.DropTable(
                name: "vehicleDbModels");
        }
    }
}
