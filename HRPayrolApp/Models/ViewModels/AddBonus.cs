using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models.ViewModels
{
    public class AddBonus
    {
        public int ID { get; set; }
        public string WorkerID { get; set; }

        public string WorkerAccount { get; set; }

        public string Reason { get; set; }

        public DateTime BonusDate { get; set; }

      
        public decimal BonusSalary { get; set; }
    }
}
