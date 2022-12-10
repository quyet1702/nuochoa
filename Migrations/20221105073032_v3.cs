using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ButterflyCarair.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Details1",
                schema: "but73756_but73756",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Details2",
                schema: "but73756_but73756",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Details3",
                schema: "but73756_but73756",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Details4",
                schema: "but73756_but73756",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Details5",
                schema: "but73756_but73756",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Details6",
                schema: "but73756_but73756",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Details7",
                schema: "but73756_but73756",
                table: "News");

            migrationBuilder.RenameColumn(
                name: "Details8",
                schema: "but73756_but73756",
                table: "News",
                newName: "Details");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Details",
                schema: "but73756_but73756",
                table: "News",
                newName: "Details8");

            migrationBuilder.AddColumn<string>(
                name: "Details1",
                schema: "but73756_but73756",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Details2",
                schema: "but73756_but73756",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Details3",
                schema: "but73756_but73756",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Details4",
                schema: "but73756_but73756",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Details5",
                schema: "but73756_but73756",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Details6",
                schema: "but73756_but73756",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Details7",
                schema: "but73756_but73756",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
