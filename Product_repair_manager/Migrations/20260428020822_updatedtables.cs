using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Product_repair_manager.Migrations
{
    /// <inheritdoc />
    public partial class updatedtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "damage_report",
                table: "Item_damages",
                newName: "severity");

            migrationBuilder.RenameColumn(
                name: "Item_date",
                table: "Item_damages",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "Item_damages",
                newName: "ItemsId");

            migrationBuilder.RenameColumn(
                name: "item_damages_id",
                table: "damages_report",
                newName: "Item_damagesId");

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "damages_report",
                newName: "ClassesId");

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "damage_type",
                table: "Item_damages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "damage_type",
                table: "Item_damages");

            migrationBuilder.RenameColumn(
                name: "severity",
                table: "Item_damages",
                newName: "damage_report");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Item_damages",
                newName: "Item_date");

            migrationBuilder.RenameColumn(
                name: "ItemsId",
                table: "Item_damages",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "Item_damagesId",
                table: "damages_report",
                newName: "item_damages_id");

            migrationBuilder.RenameColumn(
                name: "ClassesId",
                table: "damages_report",
                newName: "ClassId");
        }
    }
}
