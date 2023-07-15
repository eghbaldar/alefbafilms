using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alefbafilms.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class BaseEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteTime",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteTime",
                table: "Roles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "Roles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1L,
                columns: new[] { "DeleteTime", "InsertTime", "UpdateTime" },
                values: new object[] { null, new DateTime(2023, 7, 5, 1, 30, 56, 394, DateTimeKind.Local).AddTicks(8820), null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2L,
                columns: new[] { "DeleteTime", "InsertTime", "UpdateTime" },
                values: new object[] { null, new DateTime(2023, 7, 5, 1, 30, 56, 394, DateTimeKind.Local).AddTicks(8857), null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3L,
                columns: new[] { "DeleteTime", "InsertTime", "UpdateTime" },
                values: new object[] { null, new DateTime(2023, 7, 5, 1, 30, 56, 394, DateTimeKind.Local).AddTicks(8869), null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4L,
                columns: new[] { "DeleteTime", "InsertTime", "UpdateTime" },
                values: new object[] { null, new DateTime(2023, 7, 5, 1, 30, 56, 394, DateTimeKind.Local).AddTicks(8877), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleteTime",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "InsertTime",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeleteTime",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "InsertTime",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "Roles");
        }
    }
}
