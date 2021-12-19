using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WeddingAnniversary.Areas.User.Models;

namespace WeddingAnniversary.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Invitation> invitations { get; set; }
        public DbSet<Notes> notes { get; set; }
        public DbSet<NoteItem> noteItems { get; set; }
        public DbSet<GuestList> guestLists { get; set; }
        public DbSet<Guest> guests { get; set; }
        public DbSet<Schedule> schedules { get; set; }
        public DbSet<ScheduleItem> scheduleItems { get; set; }
    }
}
