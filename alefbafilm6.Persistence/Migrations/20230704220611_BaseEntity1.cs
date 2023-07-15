using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alefbafilms.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class BaseEntity1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 7, 5, 1, 30, 56, 394, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 7, 5, 1, 30, 56, 394, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 7, 5, 1, 30, 56, 394, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2023, 7, 5, 1, 30, 56, 394, DateTimeKind.Local).AddTicks(8877));
        }
    }
}
