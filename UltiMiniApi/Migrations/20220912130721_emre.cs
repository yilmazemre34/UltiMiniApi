using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UltiMiniApi.Migrations
{
    public partial class emre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "isDefault",
                table: "Safe",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDefault",
                table: "Safe");
        }
    }
}
