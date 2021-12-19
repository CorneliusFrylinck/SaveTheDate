using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingAnniversary.Data.Migrations
{
    public partial class addedWeddingName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WeddingName",
                table: "invitations",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WeddingName",
                table: "invitations");
        }
    }
}
