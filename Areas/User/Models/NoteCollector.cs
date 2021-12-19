using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingAnniversary.Areas.User.Models
{
    public class NoteCollector
    {
        public int Id { get; set; }
        public IEnumerable<NoteItem> Notes { get; set; }
    }
}
