using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MPOnew.Migrations
{
    public partial class EditClassStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Post_Headers_HEADERID",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "Post_Headers");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Posts_HEADERID",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "HEADERID",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "HEADER_ID",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "IMG",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "PRICE",
                table: "Posts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "TITLE",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IMG",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PRICE",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "TITLE",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "HEADERID",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HEADER_ID",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IMG = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PostID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Photos_Posts_PostID",
                        column: x => x.PostID,
                        principalTable: "Posts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Post_Headers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MAIN_PHOTOID = table.Column<int>(type: "int", nullable: true),
                    PRICE = table.Column<int>(type: "int", nullable: false),
                    TITLE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post_Headers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Post_Headers_Photos_MAIN_PHOTOID",
                        column: x => x.MAIN_PHOTOID,
                        principalTable: "Photos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_HEADERID",
                table: "Posts",
                column: "HEADERID");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_PostID",
                table: "Photos",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_Post_Headers_MAIN_PHOTOID",
                table: "Post_Headers",
                column: "MAIN_PHOTOID");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Post_Headers_HEADERID",
                table: "Posts",
                column: "HEADERID",
                principalTable: "Post_Headers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
