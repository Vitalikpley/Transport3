using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TransportMigration.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StopStations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StopStations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    StartValid = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndValid = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TransportLineId = table.Column<int>(type: "INTEGER", nullable: false),
                    StopStationId = table.Column<int>(type: "INTEGER", nullable: false),
                    ArrivelTime = table.Column<TimeOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_Lines_TransportLineId",
                        column: x => x.TransportLineId,
                        principalTable: "Lines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_StopStations_StopStationId",
                        column: x => x.StopStationId,
                        principalTable: "StopStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Lines",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Маршрут №1", "Автобус" },
                    { 2, "Маршрут №2", "Автобус" },
                    { 3, "Маршрут №3", "Автобус" },
                    { 4, "Маршрут №3", "Тролейбус" },
                    { 5, "Маршрут №4", "Тролейбус" },
                    { 6, "Маршрут №5", "Тролейбус" }
                });

            migrationBuilder.InsertData(
                table: "StopStations",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Вул. Івана Франка 1", "Вул. Івана Франка" },
                    { 2, "Вул. Дубнівсяка 2", "Майдан Київський" },
                    { 3, "Проспект Волі 1", "Облдержадміністрація" },
                    { 4, "Проспект Волі 2", "Технікум" },
                    { 5, "Проспект Волі 3", "Поліклініка №1" },
                    { 6, "Проспект Волі 4", "Стоматполіклініка" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "EndValid", "Price", "StartValid" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 10, 15, 34, 0, 0, DateTimeKind.Unspecified), 4.0, new DateTime(2023, 6, 10, 15, 24, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 6, 10, 15, 40, 0, 0, DateTimeKind.Unspecified), 5.0, new DateTime(2024, 5, 12, 10, 25, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 25.0, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2025, 1, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), 70.0, new DateTime(2024, 12, 4, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 500.0, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "ArrivelTime", "StopStationId", "TransportLineId" },
                values: new object[,]
                {
                    { 1, new TimeOnly(15, 15, 0), 4, 2 },
                    { 2, new TimeOnly(16, 23, 0), 3, 1 },
                    { 3, new TimeOnly(18, 10, 0), 3, 2 },
                    { 4, new TimeOnly(8, 5, 0), 1, 3 },
                    { 5, new TimeOnly(10, 56, 0), 6, 6 },
                    { 6, new TimeOnly(12, 54, 0), 5, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_StopStationId",
                table: "Schedules",
                column: "StopStationId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_TransportLineId",
                table: "Schedules",
                column: "TransportLineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Lines");

            migrationBuilder.DropTable(
                name: "StopStations");
        }
    }
}
