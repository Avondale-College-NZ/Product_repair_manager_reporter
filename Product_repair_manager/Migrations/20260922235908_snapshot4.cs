using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Product_repair_manager.Migrations
{
    /// <inheritdoc />
    public partial class snapshot4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_damages_report_AspNetUsers_UserId",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
