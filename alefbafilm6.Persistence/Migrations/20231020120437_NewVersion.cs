using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alefbafilm6.Persistence.Migrations
{
    public partial class NewVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 10, 16, 17, 8, 40, 281, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 10, 16, 17, 8, 40, 281, DateTimeKind.Local).AddTicks(3894));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 10, 16, 17, 8, 40, 281, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2023, 10, 16, 17, 8, 40, 281, DateTimeKind.Local).AddTicks(3931));
        }
    }
}
