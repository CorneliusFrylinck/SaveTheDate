using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingAnniversary.Areas.User.Models
{
    public class ReturnClass
    {
        public ReturnClass(bool success, string message)
        {
            this.success = success;
            this.message = message;
        }
        public bool success { get; set; }
        public string message { get; set; }
    }
}
