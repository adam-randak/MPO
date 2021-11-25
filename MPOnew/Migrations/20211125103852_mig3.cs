using Microsoft.EntityFrameworkCore.Migrations;

namespace MPOnew.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PHOTOS_ID",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PHOTO_ID",
                table: "Post_Headers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PHOTOS_ID",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PHOTO_ID",
                table: "Post_Headers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
