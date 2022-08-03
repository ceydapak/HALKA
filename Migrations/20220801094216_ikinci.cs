using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _HALKA.Migrations
{
    public partial class ikinci : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookScore",
                table: "Users",
                newName: "CouponId");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "Users",
                newName: "UserId");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Coupons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LibraryId1",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CouponId",
                table: "Users",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_LibraryId",
                table: "Users",
                column: "LibraryId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookCategoryId",
                table: "Books",
                column: "BookCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_LibraryId1",
                table: "Books",
                column: "LibraryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookCategories_BookCategoryId",
                table: "Books",
                column: "BookCategoryId",
                principalTable: "BookCategories",
                principalColumn: "BookCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Libraries_LibraryId1",
                table: "Books",
                column: "LibraryId1",
                principalTable: "Libraries",
                principalColumn: "LibraryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Coupons_CouponId",
                table: "Users",
                column: "CouponId",
                principalTable: "Coupons",
                principalColumn: "CouponsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Libraries_LibraryId",
                table: "Users",
                column: "LibraryId",
                principalTable: "Libraries",
                principalColumn: "LibraryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookCategories_BookCategoryId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Libraries_LibraryId1",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Coupons_CouponId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Libraries_LibraryId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CouponId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_LibraryId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookCategoryId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_LibraryId1",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Coupons");

            migrationBuilder.DropColumn(
                name: "LibraryId1",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "CouponId",
                table: "Users",
                newName: "BookScore");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "UsersId");
        }
    }
}
