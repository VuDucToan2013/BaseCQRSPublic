using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class td1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name3",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name3",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
