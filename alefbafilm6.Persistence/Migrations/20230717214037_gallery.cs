using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alefbafilms.Persistence.Migrations
{
    public partial class gallery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gallery",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Filename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gallery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GalleryCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GalleryId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleryCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GalleryCategory_Gallery_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "Gallery",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GalleryInCategory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GalleryId = table.Column<long>(type: "bigint", nullable: false),
                    IdGallery = table.Column<long>(type: "bigint", nullable: false),
                    GalleryCategoryId = table.Column<int>(type: "int", nullable: false),
                    IdCategory = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleryInCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GalleryInCategory_Gallery_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "Gallery",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GalleryInCategory_GalleryCategory_GalleryCategoryId",
                        column: x => x.GalleryCategoryId,
                        principalTable: "GalleryCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_GalleryInCategory_GalleryCategoryId",
                table: "GalleryInCategory",
                column: "GalleryCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_GalleryInCategory_GalleryId",
                table: "GalleryInCategory",
                column: "GalleryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GalleryInCategory");

            migrationBuilder.DropTable(
                name: "GalleryCategory");

            migrationBuilder.DropTable(
                name: "Gallery");

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
    }
}
