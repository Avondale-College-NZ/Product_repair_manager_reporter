using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Product_repair_manager.Migrations
{
    /// <inheritdoc />
    public partial class snapshot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_damages_report_Classes_ClassesId",
                table: "damages_report");

            migrationBuilder.DropForeignKey(
                name: "FK_damages_report_Item_damages_Item_damagesId",
                table: "damages_report");

            migrationBuilder.DropIndex(
                name: "IX_damages_report_ClassesId",
                table: "damages_report");

            migrationBuilder.DropIndex(
                name: "IX_damages_report_Item_damagesId",
                table: "damages_report");

            migrationBuilder.DropColumn(
                name: "Item_date",
                table: "damages_report");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Item_date",
                table: "damages_report",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_damages_report_ClassesId",
                table: "damages_report",
                column: "ClassesId");

            migrationBuilder.CreateIndex(
                name: "IX_damages_report_Item_damagesId",
                table: "damages_report",
                column: "Item_damagesId");

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
        }
    }
}
