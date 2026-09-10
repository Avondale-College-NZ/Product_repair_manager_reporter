using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Product_repair_manager.Migrations
{
    /// <inheritdoc />
    public partial class pendingchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_damages_report_AspNetUsers_appuserId",
                table: "damages_report");

            migrationBuilder.AlterColumn<string>(
                name: "appuserId",
                table: "damages_report",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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

            migrationBuilder.AlterColumn<string>(
                name: "appuserId",
                table: "damages_report",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_damages_report_AspNetUsers_appuserId",
                table: "damages_report",
                column: "appuserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
