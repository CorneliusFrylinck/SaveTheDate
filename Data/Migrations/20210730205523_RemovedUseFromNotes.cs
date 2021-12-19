using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingAnniversary.Data.Migrations
{
    public partial class RemovedUseFromNotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Use",
                table: "notes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Use",
                table: "notes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
