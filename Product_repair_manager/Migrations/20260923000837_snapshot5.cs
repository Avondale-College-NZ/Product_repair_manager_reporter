using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Product_repair_manager.Migrations
{
    /// <inheritdoc />
    public partial class snapshot5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "damages_reportId",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemsId",
                table: "Catagory",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "damages_reportId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "ItemsId",
                table: "Catagory");
        }
    }
}
