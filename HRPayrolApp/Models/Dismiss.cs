using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models
{
    public class Dismiss
    {
        public int ID { get; set; }

        public string Reason { get; set; }

        public DateTime Date { get; set; }

        public virtual ICollection<WorkerDismiss>  WorkerDismisses { get; set; }
    }
}
