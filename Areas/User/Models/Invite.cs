using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingAnniversary.Areas.User.Models
{
    public class Invite
    {
        public int Id { get; set; }
        public string OwnerEmail { get; set; }
        public string Venue { get; set; }
        public DateTime WeddingDate { get; set; }
        public DateTime RSVPDate { get; set; }
#nullable enable
        public int? NotesId { get; set; }
        [ForeignKey("NotesId")]
        public Notes? Notes { get; set; }
        public string? WeddingName { get; set; }
        public string? InvitationIntro { get; set; }
        public string? OurStory { get; set; }
        public int? ScheduleId { get; set; }
        [ForeignKey("ScheduleId")]
        public Schedule? Schedule { get; set; }
        public string? VenueLocation { get; set; }
        public string? VenueWebsite { get; set; }

    }
}
