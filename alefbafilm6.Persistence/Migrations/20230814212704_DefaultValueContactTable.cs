using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alefbafilm6.Persistence.Migrations
{
    public partial class DefaultValueContactTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsCheck",
                table: "Contacts",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 8, 15, 0, 57, 3, 971, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 8, 15, 0, 57, 3, 971, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 8, 15, 0, 57, 3, 971, DateTimeKind.Local).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2023, 8, 15, 0, 57, 3, 971, DateTimeKind.Local).AddTicks(2625));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsCheck",
                table: "Contacts",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

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
    }
}
