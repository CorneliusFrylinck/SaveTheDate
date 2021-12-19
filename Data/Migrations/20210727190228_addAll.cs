using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingAnniversary.Data.Migrations
{
    public partial class addAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "guestLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guestLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Use = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schedules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "guests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AllowedPusOne = table.Column<bool>(type: "bit", nullable: false),
                    GuestListId = table.Column<int>(type: "int", nullable: false),
                    RSVP = table.Column<bool>(type: "bit", nullable: false),
                    PlusOne = table.Column<bool>(type: "bit", nullable: true),
                    PlusOneName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PlusOneSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NotesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_guests_guestLists_GuestListId",
                        column: x => x.GuestListId,
                        principalTable: "guestLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_guests_notes_NotesId",
                        column: x => x.NotesId,
                        principalTable: "notes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "noteItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotesId = table.Column<int>(type: "int", nullable: false),
                    NoteValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_noteItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_noteItems_notes_NotesId",
                        column: x => x.NotesId,
                        principalTable: "notes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "invitations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvitationIntro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurStory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScheduleId = table.Column<int>(type: "int", nullable: true),
                    Venue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VenueLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VenueWebsite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeddingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RSVPDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invitations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_invitations_schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "scheduleItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleId = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ItemDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ItemTime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NotesId = table.Column<int>(type: "int", nullable: true),
                    GuestListId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scheduleItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_scheduleItems_guestLists_GuestListId",
                        column: x => x.GuestListId,
                        principalTable: "guestLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_scheduleItems_notes_NotesId",
                        column: x => x.NotesId,
                        principalTable: "notes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_scheduleItems_schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_guests_GuestListId",
                table: "guests",
                column: "GuestListId");

            migrationBuilder.CreateIndex(
                name: "IX_guests_NotesId",
                table: "guests",
                column: "NotesId");

            migrationBuilder.CreateIndex(
                name: "IX_invitations_ScheduleId",
                table: "invitations",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_noteItems_NotesId",
                table: "noteItems",
                column: "NotesId");

            migrationBuilder.CreateIndex(
                name: "IX_scheduleItems_GuestListId",
                table: "scheduleItems",
                column: "GuestListId");

            migrationBuilder.CreateIndex(
                name: "IX_scheduleItems_NotesId",
                table: "scheduleItems",
                column: "NotesId");

            migrationBuilder.CreateIndex(
                name: "IX_scheduleItems_ScheduleId",
                table: "scheduleItems",
                column: "ScheduleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "guests");

            migrationBuilder.DropTable(
                name: "invitations");

            migrationBuilder.DropTable(
                name: "noteItems");

            migrationBuilder.DropTable(
                name: "scheduleItems");

            migrationBuilder.DropTable(
                name: "guestLists");

            migrationBuilder.DropTable(
                name: "notes");

            migrationBuilder.DropTable(
                name: "schedules");
        }
    }
}
