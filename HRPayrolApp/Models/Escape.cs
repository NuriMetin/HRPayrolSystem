using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models
{
    public class Escape
    {
        public int ID { get; set; }

        public string EscapeReason { get; set; }

        public DateTime EscapeDate { get; set; }

        public string WorkerId { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
