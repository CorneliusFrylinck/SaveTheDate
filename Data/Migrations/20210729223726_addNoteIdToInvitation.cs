using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingAnniversary.Data.Migrations
{
    public partial class addNoteIdToInvitation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NotesId",
                table: "invitations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_invitations_NotesId",
                table: "invitations",
                column: "NotesId");

            migrationBuilder.AddForeignKey(
                name: "FK_invitations_notes_NotesId",
                table: "invitations",
                column: "NotesId",
                principalTable: "notes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_invitations_notes_NotesId",
                table: "invitations");

            migrationBuilder.DropIndex(
                name: "IX_invitations_NotesId",
                table: "invitations");

            migrationBuilder.DropColumn(
                name: "NotesId",
                table: "invitations");
        }
    }
}
