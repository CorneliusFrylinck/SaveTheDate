using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingAnniversary.Areas.User.Models
{
    public class Guest
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Surname { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        public bool AllowedPusOne { get; set; }
        public int GuestListId { get; set; }
        [ForeignKey("GuestListId")]
        public GuestList GuestList { get; set; }
        public bool RSVP { get; set; }
#nullable enable
        public bool? PlusOne { get; set; }
        [MaxLength(50)]
        public string? PlusOneName { get; set; }
        [MaxLength(50)]
        public string? PlusOneSurname { get; set; }
    }
}
