using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingAnniversary.Areas.User.Models
{
    public class NoteItem
    {
        public int Id { get; set; }
        public int NotesId { get; set; }
        [ForeignKey("NotesId")]
        public Notes Notes { get; set; }
        public string NoteValue { get; set; }
    }
}
