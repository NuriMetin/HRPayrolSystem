using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models
{
    public class OldWorkPlace
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime EnterDate { get; set; }
        public string LeaveReason { get; set; }
        public DateTime LeaveDate { get; set; }
        public string WorkerId { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
