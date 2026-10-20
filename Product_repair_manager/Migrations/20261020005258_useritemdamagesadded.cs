using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Product_repair_manager.Migrations
{
    /// <inheritdoc />
    public partial class useritemdamagesadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "Item_damages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Item_damagesId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Item_damagesId",
                table: "AspNetUsers",
                column: "Item_damagesId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Item_damages_Item_damagesId",
                table: "AspNetUsers",
                column: "Item_damagesId",
                principalTable: "Item_damages",
                principalColumn: "Item_damagesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Item_damages_Item_damagesId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Item_damagesId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Item_damages");

            migrationBuilder.DropColumn(
                name: "Item_damagesId",
                table: "AspNetUsers");
        }
    }
}
