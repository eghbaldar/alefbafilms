using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alefbafilm6.Persistence.Migrations
{
    public partial class addContactTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Organization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCheck = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 8, 15, 0, 12, 38, 877, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 8, 15, 0, 12, 38, 877, DateTimeKind.Local).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 8, 15, 0, 12, 38, 877, DateTimeKind.Local).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2023, 8, 15, 0, 12, 38, 877, DateTimeKind.Local).AddTicks(3624));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 8, 12, 1, 26, 8, 290, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 8, 12, 1, 26, 8, 290, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 8, 12, 1, 26, 8, 290, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2023, 8, 12, 1, 26, 8, 290, DateTimeKind.Local).AddTicks(823));
        }
    }
}
