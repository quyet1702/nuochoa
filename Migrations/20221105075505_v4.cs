using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ButterflyCarair.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FragranceGroup",
                schema: "but73756_but73756",
                table: "Product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FragranceGroup",
                schema: "but73756_but73756",
                table: "Product",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }
    }
}
