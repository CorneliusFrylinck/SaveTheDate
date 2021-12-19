using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingAnniversary.Areas.User.Models
{
    public class ScheduleItem
    {
        public int Id { get; set; }
        public int ScheduleId { get; set; }

        [ForeignKey("ScheduleId")]
        public Schedule Schedule { get; set; }
        [MaxLength(50)]
        public string ItemName { get; set; }
        [MaxLength(50)]
#nullable enable
        public string? ItemDescription { get; set; }
        [MaxLength(50)]
        public string? ItemTime { get; set; }

    }
}
