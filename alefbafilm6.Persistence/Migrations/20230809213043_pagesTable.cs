using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alefbafilm6.Persistence.Migrations
{
    public partial class pagesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutPage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 8, 10, 1, 0, 43, 267, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 8, 10, 1, 0, 43, 267, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 8, 10, 1, 0, 43, 267, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2023, 8, 10, 1, 0, 43, 267, DateTimeKind.Local).AddTicks(8832));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 8, 7, 2, 14, 54, 544, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 8, 7, 2, 14, 54, 544, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 8, 7, 2, 14, 54, 544, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2023, 8, 7, 2, 14, 54, 544, DateTimeKind.Local).AddTicks(9920));
        }
    }
}
