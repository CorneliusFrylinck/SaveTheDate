using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingAnniversary.Data.Migrations
{
    public partial class MovedGuestListIdToInvitation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_scheduleItems_guestLists_GuestListId",
                table: "scheduleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_scheduleItems_notes_NotesId",
                table: "scheduleItems");

            migrationBuilder.DropIndex(
                name: "IX_scheduleItems_GuestListId",
                table: "scheduleItems");

            migrationBuilder.DropIndex(
                name: "IX_scheduleItems_NotesId",
                table: "scheduleItems");

            migrationBuilder.DropColumn(
                name: "GuestListId",
                table: "scheduleItems");

            migrationBuilder.DropColumn(
                name: "NotesId",
                table: "scheduleItems");

            migrationBuilder.AddColumn<int>(
                name: "GuestListId",
                table: "invitations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "GuestsOnly",
                table: "invitations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_invitations_GuestListId",
                table: "invitations",
                column: "GuestListId");

            migrationBuilder.AddForeignKey(
                name: "FK_invitations_guestLists_GuestListId",
                table: "invitations",
                column: "GuestListId",
                principalTable: "guestLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_invitations_guestLists_GuestListId",
                table: "invitations");

            migrationBuilder.DropIndex(
                name: "IX_invitations_GuestListId",
                table: "invitations");

            migrationBuilder.DropColumn(
                name: "GuestListId",
                table: "invitations");

            migrationBuilder.DropColumn(
                name: "GuestsOnly",
                table: "invitations");

            migrationBuilder.AddColumn<int>(
                name: "GuestListId",
                table: "scheduleItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NotesId",
                table: "scheduleItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_scheduleItems_GuestListId",
                table: "scheduleItems",
                column: "GuestListId");

            migrationBuilder.CreateIndex(
                name: "IX_scheduleItems_NotesId",
                table: "scheduleItems",
                column: "NotesId");

            migrationBuilder.AddForeignKey(
                name: "FK_scheduleItems_guestLists_GuestListId",
                table: "scheduleItems",
                column: "GuestListId",
                principalTable: "guestLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_scheduleItems_notes_NotesId",
                table: "scheduleItems",
                column: "NotesId",
                principalTable: "notes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
