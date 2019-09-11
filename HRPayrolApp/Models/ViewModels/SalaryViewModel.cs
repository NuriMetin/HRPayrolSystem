using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models.ViewModels
{
    public class SalaryViewModel
    {
        public int ID { get; set; }
        public string WorkerId { get; set; }
        public string WorkerAccount { get; set; }
        public decimal Bonus { get; set; }
        public string Position { get; set; }
        public decimal MonthlySalary { get; set; }
        public int ExcusableAbsens { get; set; }
        public int UnExcusableAbsens { get; set; }
        public int AbsensCount { get; set; }
        public int SalaryFromBank { get; set; }
        public decimal TotalSalary { get; set; }
    }
}
