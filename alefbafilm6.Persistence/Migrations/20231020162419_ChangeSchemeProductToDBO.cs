using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alefbafilm6.Persistence.Migrations
{
    public partial class ChangeSchemeProductToDBO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Products",
                newSchema: "dbo");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 10, 20, 19, 54, 18, 940, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 10, 20, 19, 54, 18, 940, DateTimeKind.Local).AddTicks(4878));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 10, 20, 19, 54, 18, 940, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2023, 10, 20, 19, 54, 18, 940, DateTimeKind.Local).AddTicks(4893));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Products",
                schema: "dbo",
                newName: "Products");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 10, 20, 15, 34, 37, 606, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 10, 20, 15, 34, 37, 606, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 10, 20, 15, 34, 37, 606, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2023, 10, 20, 15, 34, 37, 606, DateTimeKind.Local).AddTicks(7916));
        }
    }
}
