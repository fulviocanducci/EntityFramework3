using Microsoft.EntityFrameworkCore.Migrations;

namespace core.Migrations
{
    public partial class ActiveFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Peoples",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Books",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Books");
        }
    }
}
