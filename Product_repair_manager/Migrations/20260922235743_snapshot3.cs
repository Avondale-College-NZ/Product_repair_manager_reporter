using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Product_repair_manager.Migrations
{
    /// <inheritdoc />
    public partial class snapshot3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_damages_report_AspNetUsers_ApplicationUserId",
                table: "damages_report");

            migrationBuilder.DropIndex(
                name: "IX_damages_report_ApplicationUserId",
                table: "damages_report");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "damages_report");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "damages_report",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CatagoryId",
                table: "Items",
                column: "CatagoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_damages_ItemsId",
                table: "Item_damages",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_damages_report_ClassesId",
                table: "damages_report",
                column: "ClassesId");

            migrationBuilder.CreateIndex(
                name: "IX_damages_report_Item_damagesId",
                table: "damages_report",
                column: "Item_damagesId");

            migrationBuilder.CreateIndex(
                name: "IX_damages_report_UserId",
                table: "damages_report",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_damages_report_AspNetUsers_UserId",
                table: "damages_report",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_damages_report_Classes_ClassesId",
                table: "damages_report",
                column: "ClassesId",
                principalTable: "Classes",
                principalColumn: "ClassesId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_damages_report_Item_damages_Item_damagesId",
                table: "damages_report",
                column: "Item_damagesId",
                principalTable: "Item_damages",
                principalColumn: "Item_damagesId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_damages_Items_ItemsId",
                table: "Item_damages",
                column: "ItemsId",
                principalTable: "Items",
                principalColumn: "ItemsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Catagory_CatagoryId",
                table: "Items",
                column: "CatagoryId",
                principalTable: "Catagory",
                principalColumn: "CatagoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_damages_report_AspNetUsers_UserId",
                table: "damages_report");

            migrationBuilder.DropForeignKey(
                name: "FK_damages_report_Classes_ClassesId",
                table: "damages_report");

            migrationBuilder.DropForeignKey(
                name: "FK_damages_report_Item_damages_Item_damagesId",
                table: "damages_report");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_damages_Items_ItemsId",
                table: "Item_damages");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Catagory_CatagoryId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_CatagoryId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Item_damages_ItemsId",
                table: "Item_damages");

            migrationBuilder.DropIndex(
                name: "IX_damages_report_ClassesId",
                table: "damages_report");

            migrationBuilder.DropIndex(
                name: "IX_damages_report_Item_damagesId",
                table: "damages_report");

            migrationBuilder.DropIndex(
                name: "IX_damages_report_UserId",
                table: "damages_report");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "damages_report",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "damages_report",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_damages_report_ApplicationUserId",
                table: "damages_report",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_damages_report_AspNetUsers_ApplicationUserId",
                table: "damages_report",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
