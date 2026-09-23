using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Product_repair_manager.Migrations
{
    /// <inheritdoc />
    public partial class snapshot6 : Migration
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

            migrationBuilder.AddColumn<string>(
                name: "appuserId",
                table: "damages_report",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_damages_report_appuserId",
                table: "damages_report",
                column: "appuserId");

            migrationBuilder.AddForeignKey(
                name: "FK_damages_report_AspNetUsers_appuserId",
                table: "damages_report",
                column: "appuserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_damages_report_AspNetUsers_appuserId",
                table: "damages_report");

            migrationBuilder.DropIndex(
                name: "IX_damages_report_appuserId",
                table: "damages_report");

            migrationBuilder.DropColumn(
                name: "appuserId",
                table: "damages_report");

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
