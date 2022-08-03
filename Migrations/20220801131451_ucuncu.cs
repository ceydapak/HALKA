using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _HALKA.Migrations
{
    public partial class ucuncu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CouponsId",
                table: "Coupons",
                newName: "CouponId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CouponId",
                table: "Coupons",
                newName: "CouponsId");
        }
    }
}
