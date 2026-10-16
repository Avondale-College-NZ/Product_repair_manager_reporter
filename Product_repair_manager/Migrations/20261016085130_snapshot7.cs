using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Product_repair_manager.Migrations
{
    /// <inheritdoc />
    public partial class snapshot7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_damages_report_AspNetUsers_appuserId",
                table: "damages_report");

            migrationBuilder.DropPrimaryKey(
                name: "PK_damages_report",
                table: "damages_report");

            migrationBuilder.AlterColumn<int>(
                name: "damages_reportId",
                table: "damages_report",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "appuserId",
                table: "damages_report",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "damages_report",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_damages_report",
                table: "damages_report",
                column: "damages_reportId");

            migrationBuilder.AddForeignKey(
                name: "FK_damages_report_AspNetUsers_appuserId",
                table: "damages_report",
                column: "appuserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_damages_report_AspNetUsers_appuserId",
                table: "damages_report");

            migrationBuilder.DropPrimaryKey(
                name: "PK_damages_report",
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

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "damages_report",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "damages_reportId",
                table: "damages_report",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_damages_report",
                table: "damages_report",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_damages_report_AspNetUsers_appuserId",
                table: "damages_report",
                column: "appuserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
