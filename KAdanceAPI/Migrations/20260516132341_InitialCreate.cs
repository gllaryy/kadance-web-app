using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 

namespace KAdanceAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Surname = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DanceClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    DayOfWeek = table.Column<string>(type: "TEXT", nullable: false),
                    TimeStart = table.Column<string>(type: "TEXT", nullable: false),
                    TimeEnd = table.Column<string>(type: "TEXT", nullable: false),
                    Trainer = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanceClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClientId = table.Column<int>(type: "INTEGER", nullable: false),
                    DanceClassId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registrations_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registrations_DanceClasses_DanceClassId",
                        column: x => x.DanceClassId,
                        principalTable: "DanceClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DanceClasses",
                columns: new[] { "Id", "DayOfWeek", "Name", "TimeEnd", "TimeStart", "Trainer" },
                values: new object[,]
                {
                    { 1, "Понеділок", "Пілатес", "10:00", "09:00", "Ксенія" },
                    { 2, "Понеділок", "Стретчинг", "11:00", "10:00", "Ксенія" },
                    { 3, "Понеділок", "Айро фітнес", "12:00", "11:00", "Ксенія" },
                    { 4, "Понеділок", "Контемпорарі 8-11 років", "17:00", "15:30", "Ксенія" },
                    { 5, "Понеділок", "Контемпорарі 12-16 років", "18:30", "17:00", "Ксенія" },
                    { 6, "Понеділок", "Пілатес", "20:00", "19:00", "Ксенія" },
                    { 7, "Понеділок", "Стретчинг", "21:00", "20:00", "Ксенія" },
                    { 8, "Вівторок", "Пілатес+стретчинг", "11:00", "10:00", "Ксенія" },
                    { 9, "Вівторок", "Контемпорарі", "12:00", "11:00", "Ксенія" },
                    { 10, "Вівторок", "Флай стретчинг", "13:00", "12:00", "Ксенія" },
                    { 11, "Вівторок", "ЛФК+акробатика 8-13 років", "18:00", "17:00", "Ксенія" },
                    { 12, "Вівторок", "Гімнастика+ритміка 3-5 років", "19:00", "18:00", "Ольга" },
                    { 13, "Вівторок", "Релакс стретчинг", "20:00", "19:00", "Ольга" },
                    { 14, "Вівторок", "Барре", "21:00", "20:00", "Ольга" },
                    { 15, "Середа", "Пілатес", "10:00", "09:00", "Ксенія" },
                    { 16, "Середа", "Стретчинг", "11:00", "10:00", "Ксенія" },
                    { 17, "Середа", "Айро фітнес", "12:00", "11:00", "Ксенія" },
                    { 18, "Середа", "Контемпорарі 8-11 років", "17:00", "15:30", "Ксенія" },
                    { 19, "Середа", "Контемпорарі 12-16 років", "18:30", "17:00", "Ксенія" },
                    { 20, "Середа", "Пілатес", "20:00", "19:00", "Ксенія" },
                    { 21, "Середа", "Стретчинг", "21:00", "20:00", "Ксенія" },
                    { 22, "Четвер", "Пілатес+стретчинг", "11:00", "10:00", "Ксенія" },
                    { 23, "Четвер", "Контемпорарі", "12:00", "11:00", "Ксенія" },
                    { 24, "Четвер", "Флай стретчинг", "13:00", "12:00", "Ксенія" },
                    { 25, "Четвер", "ЛФК+акробатика 8-13 років", "17:30", "16:30", "Ксенія" },
                    { 26, "Четвер", "Флай акробатика 9-14 років", "18:30", "17:30", "Марія" },
                    { 27, "Четвер", "Флай стретчинг", "19:30", "18:30", "Ксенія" },
                    { 28, "Четвер", "Зумба", "20:30", "19:30", "Марія" },
                    { 29, "Четвер", "Айро фітнес", "21:30", "20:30", "Марія" },
                    { 30, "П'ятниця", "Пілатес", "10:00", "09:00", "Ксенія" },
                    { 31, "П'ятниця", "МФР стретчинг", "11:00", "10:00", "Ксенія" },
                    { 32, "П'ятниця", "Контемпорарі 8-16 років", "18:00", "17:00", "Ксенія" },
                    { 33, "П'ятниця", "Гімнастика+ритміка 3-5 років", "19:00", "18:00", "Ольга" },
                    { 34, "П'ятниця", "Пілатес+стретчинг", "20:00", "19:00", "Ксенія" },
                    { 35, "Субота", "Релакс стретчинг", "20:00", "19:00", "Ольга" },
                    { 36, "Субота", "Барре", "21:00", "20:00", "Ольга" },
                    { 37, "Неділя", "Флай акробатика 9-14 років", "18:30", "17:30", "Марія" },
                    { 38, "Неділя", "Зумба", "19:30", "18:30", "Марія" },
                    { 39, "Неділя", "Айро фітнес", "20:30", "19:30", "Марія" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_ClientId",
                table: "Registrations",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_DanceClassId",
                table: "Registrations",
                column: "DanceClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "DanceClasses");
        }
    }
}
