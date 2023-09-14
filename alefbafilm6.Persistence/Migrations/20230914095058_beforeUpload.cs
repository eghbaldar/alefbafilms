using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alefbafilm6.Persistence.Migrations
{
    public partial class beforeUpload : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "alefUsersEghbaldar",
                newSchema: "dbo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_alefUsersEghbaldar",
                schema: "dbo",
                table: "alefUsersEghbaldar",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 9, 14, 13, 20, 58, 370, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 9, 14, 13, 20, 58, 370, DateTimeKind.Local).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 9, 14, 13, 20, 58, 370, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2023, 9, 14, 13, 20, 58, 370, DateTimeKind.Local).AddTicks(3040));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_alefUsersEghbaldar",
                schema: "dbo",
                table: "alefUsersEghbaldar");

            migrationBuilder.RenameTable(
                name: "alefUsersEghbaldar",
                schema: "dbo",
                newName: "Contacts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 9, 11, 15, 14, 0, 997, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 9, 11, 15, 14, 0, 997, DateTimeKind.Local).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 9, 11, 15, 14, 0, 997, DateTimeKind.Local).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2023, 9, 11, 15, 14, 0, 997, DateTimeKind.Local).AddTicks(6171));
        }
    }
}
