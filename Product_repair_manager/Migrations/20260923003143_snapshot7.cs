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
            migrationBuilder.DropPrimaryKey(
                name: "PK_damages_report",
                table: "damages_report");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "damages_report");

            migrationBuilder.AlterColumn<int>(
                name: "damages_reportId",
                table: "damages_report",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "damages_report",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_damages_report",
                table: "damages_report",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_damages_report",
                table: "damages_report");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "damages_report");

            migrationBuilder.AlterColumn<int>(
                name: "damages_reportId",
                table: "damages_report",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "damages_report",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_damages_report",
                table: "damages_report",
                column: "damages_reportId");
        }
    }
}
