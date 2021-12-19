using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingAnniversary.Data.Migrations
{
    public partial class RemovedNotesFromGuest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_guests_notes_NotesId",
                table: "guests");

            migrationBuilder.DropIndex(
                name: "IX_guests_NotesId",
                table: "guests");

            migrationBuilder.DropColumn(
                name: "NotesId",
                table: "guests");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NotesId",
                table: "guests",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_guests_NotesId",
                table: "guests",
                column: "NotesId");

            migrationBuilder.AddForeignKey(
                name: "FK_guests_notes_NotesId",
                table: "guests",
                column: "NotesId",
                principalTable: "notes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
