using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sales_db.Migrations
{
    /// <inheritdoc />
    public partial class Add_CK_Products_Quantity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddCheckConstraint(
                name: "CK_Products_Quantity_RealNumber",
                table: "Products",
                sql: "[Quantity] >= 0");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Products_Quantity_RealNumber",
                table: "Products");
        }
    }
}
