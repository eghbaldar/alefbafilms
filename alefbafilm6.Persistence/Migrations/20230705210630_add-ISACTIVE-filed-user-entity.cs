using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alefbafilms.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addISACTIVEfileduserentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 7, 6, 0, 36, 30, 238, DateTimeKind.Local).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 7, 6, 0, 36, 30, 238, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 7, 6, 0, 36, 30, 238, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2023, 7, 6, 0, 36, 30, 238, DateTimeKind.Local).AddTicks(6090));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 7, 5, 1, 36, 11, 40, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 7, 5, 1, 36, 11, 40, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 7, 5, 1, 36, 11, 40, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2023, 7, 5, 1, 36, 11, 40, DateTimeKind.Local).AddTicks(3383));
        }
    }
}
