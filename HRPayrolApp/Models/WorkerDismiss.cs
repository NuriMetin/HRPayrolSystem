using HRPayrolApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models
{
    public class WorkerDismiss
    {
        public int ID { get; set; }
        public int DismissId { get; set; }
        public virtual Dismiss Dismiss { get; set; }

        public string WorkerId { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
