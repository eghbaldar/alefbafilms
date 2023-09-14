using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alefbafilm6.Persistence.Migrations
{
    public partial class beforeUpload3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Users",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "UserInRoles",
                newName: "UserInRoles",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Staff",
                newName: "Staff",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "Roles",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Pages",
                newName: "Pages",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Newsletters",
                newName: "Newsletters",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "GalleryInCategory",
                newName: "GalleryInCategory",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "GalleryCategory",
                newName: "GalleryCategory",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Gallery",
                newName: "Gallery",
                newSchema: "dbo");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 9, 14, 13, 30, 22, 284, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 9, 14, 13, 30, 22, 284, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 9, 14, 13, 30, 22, 284, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Roles",
                keyColumn: "id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2023, 9, 14, 13, 30, 22, 284, DateTimeKind.Local).AddTicks(3153));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Users",
                schema: "dbo",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "UserInRoles",
                schema: "dbo",
                newName: "UserInRoles");

            migrationBuilder.RenameTable(
                name: "Staff",
                schema: "dbo",
                newName: "Staff");

            migrationBuilder.RenameTable(
                name: "Roles",
                schema: "dbo",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "Pages",
                schema: "dbo",
                newName: "Pages");

            migrationBuilder.RenameTable(
                name: "Newsletters",
                schema: "dbo",
                newName: "Newsletters");

            migrationBuilder.RenameTable(
                name: "GalleryInCategory",
                schema: "dbo",
                newName: "GalleryInCategory");

            migrationBuilder.RenameTable(
                name: "GalleryCategory",
                schema: "dbo",
                newName: "GalleryCategory");

            migrationBuilder.RenameTable(
                name: "Gallery",
                schema: "dbo",
                newName: "Gallery");

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
    }
}
