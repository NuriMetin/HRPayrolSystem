using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models
{
    public class WorkerAbsens
    {
        public int ID { get; set; }

        public string WorkerId { get; set; }
        public virtual Worker Worker { get; set; }

        public DateTime Date { get; set; }

        public string Reason { get; set; }

        public int AbsensId { get; set; }
        public virtual Absens Absens { get; set; }
    }
}
