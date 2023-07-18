using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alefbafilms.Persistence.Migrations
{
    public partial class gallery2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GalleryCategory_Gallery_GalleryId",
                table: "GalleryCategory");

            migrationBuilder.DropIndex(
                name: "IX_GalleryCategory_GalleryId",
                table: "GalleryCategory");

            migrationBuilder.DropColumn(
                name: "GalleryId",
                table: "GalleryCategory");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 7, 18, 2, 19, 14, 431, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 7, 18, 2, 19, 14, 431, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 7, 18, 2, 19, 14, 431, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2023, 7, 18, 2, 19, 14, 431, DateTimeKind.Local).AddTicks(8475));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "GalleryId",
                table: "GalleryCategory",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 7, 18, 1, 10, 37, 383, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 7, 18, 1, 10, 37, 383, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 7, 18, 1, 10, 37, 383, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2023, 7, 18, 1, 10, 37, 383, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.CreateIndex(
                name: "IX_GalleryCategory_GalleryId",
                table: "GalleryCategory",
                column: "GalleryId");

            migrationBuilder.AddForeignKey(
                name: "FK_GalleryCategory_Gallery_GalleryId",
                table: "GalleryCategory",
                column: "GalleryId",
                principalTable: "Gallery",
                principalColumn: "Id");
        }
    }
}
