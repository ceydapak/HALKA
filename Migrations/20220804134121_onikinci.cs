using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _HALKA.Migrations
{
    public partial class onikinci : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserImgUrl",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LibraryImgUrl",
                table: "Libraries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BookImgUrl",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserImgUrl",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LibraryImgUrl",
                table: "Libraries");

            migrationBuilder.DropColumn(
                name: "BookImgUrl",
                table: "Books");
        }
    }
}
