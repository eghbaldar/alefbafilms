using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alefbafilm6.Persistence.Migrations
{
    public partial class beforeUpload2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_alefUsersEghbaldar",
                schema: "dbo",
                table: "alefUsersEghbaldar");

            migrationBuilder.RenameTable(
                name: "alefUsersEghbaldar",
                schema: "dbo",
                newName: "Contacts",
                newSchema: "dbo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                schema: "dbo",
                table: "Contacts",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 9, 14, 13, 24, 38, 735, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 9, 14, 13, 24, 38, 735, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 9, 14, 13, 24, 38, 735, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2023, 9, 14, 13, 24, 38, 735, DateTimeKind.Local).AddTicks(7289));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                schema: "dbo",
                table: "Contacts");

            migrationBuilder.RenameTable(
                name: "Contacts",
                schema: "dbo",
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
    }
}
