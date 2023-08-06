using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alefbafilm6.Persistence.Migrations
{
    public partial class fromSquareOne : Migration
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleryCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
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

            migrationBuilder.CreateTable(
                name: "UserInRoles",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInRoles", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserInRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserInRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "DeleteTime", "InsertTime", "UpdateTime", "name" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2023, 8, 5, 1, 56, 24, 975, DateTimeKind.Local).AddTicks(2213), null, "Admin" },
                    { 2L, null, new DateTime(2023, 8, 5, 1, 56, 24, 975, DateTimeKind.Local).AddTicks(2307), null, "Operator" },
                    { 3L, null, new DateTime(2023, 8, 5, 1, 56, 24, 975, DateTimeKind.Local).AddTicks(2320), null, "User" },
                    { 4L, null, new DateTime(2023, 8, 5, 1, 56, 24, 975, DateTimeKind.Local).AddTicks(2333), null, "Guest" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GalleryInCategory_GalleryCategoryId",
                table: "GalleryInCategory",
                column: "GalleryCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_GalleryInCategory_GalleryId",
                table: "GalleryInCategory",
                column: "GalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInRoles_RoleId",
                table: "UserInRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInRoles_UserId",
                table: "UserInRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_email",
                table: "Users",
                column: "email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GalleryInCategory");

            migrationBuilder.DropTable(
                name: "UserInRoles");

            migrationBuilder.DropTable(
                name: "Gallery");

            migrationBuilder.DropTable(
                name: "GalleryCategory");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
