using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models
{
    public class WorkPlace
    {
        public int ID { get; set; }
        public string WorkName { get; set; }
        public DateTime EnterDate { get; set; }
        public string LeaveReason { get; set; }
        public DateTime LeaveDate { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
