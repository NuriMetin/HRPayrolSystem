using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models.ViewModels
{
    public class AddAbsens
    {
        public int ID { get; set; }

        public string WorkerId { get; set; }

        public string WorkerAccount { get; set; }

        public DateTime Date { get; set; }

        public string Reason { get; set; }

        public int SelectedAbsens { get; set; }
        public IEnumerable<Absens> Absens { get; set; }

        public int AbsensId { get; set; }
    }
}
