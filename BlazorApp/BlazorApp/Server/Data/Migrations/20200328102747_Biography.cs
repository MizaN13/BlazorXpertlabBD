using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp.Server.Data.Migrations
{
    public partial class Biography : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Biography",
                table: "People",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Biography",
                table: "People");
        }
    }
}
