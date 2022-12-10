using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ButterflyCarair.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Describe1",
                schema: "but73756_but73756",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Describe2",
                schema: "but73756_but73756",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Describe3",
                schema: "but73756_but73756",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Describe4",
                schema: "but73756_but73756",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Describe5",
                schema: "but73756_but73756",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Describe6",
                schema: "but73756_but73756",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Describe7",
                schema: "but73756_but73756",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Describe8",
                schema: "but73756_but73756",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UsageAndCare1",
                schema: "but73756_but73756",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UsageAndCare2",
                schema: "but73756_but73756",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UsageAndCare3",
                schema: "but73756_but73756",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UsageAndCare4",
                schema: "but73756_but73756",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UsageAndCare5",
                schema: "but73756_but73756",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UsageAndCare6",
                schema: "but73756_but73756",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UsageAndCare7",
                schema: "but73756_but73756",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UsageAndCare8",
                schema: "but73756_but73756",
                table: "Product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Describe1",
                schema: "but73756_but73756",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Describe2",
                schema: "but73756_but73756",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Describe3",
                schema: "but73756_but73756",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Describe4",
                schema: "but73756_but73756",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Describe5",
                schema: "but73756_but73756",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Describe6",
                schema: "but73756_but73756",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Describe7",
                schema: "but73756_but73756",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Describe8",
                schema: "but73756_but73756",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsageAndCare1",
                schema: "but73756_but73756",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsageAndCare2",
                schema: "but73756_but73756",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsageAndCare3",
                schema: "but73756_but73756",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsageAndCare4",
                schema: "but73756_but73756",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsageAndCare5",
                schema: "but73756_but73756",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsageAndCare6",
                schema: "but73756_but73756",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsageAndCare7",
                schema: "but73756_but73756",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsageAndCare8",
                schema: "but73756_but73756",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
