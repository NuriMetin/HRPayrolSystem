using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models.ViewModels
{
    public class SalaryModel
    {
        public string WorkerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IDCardNumber { get; set; }
        public string IDCardFincode { get; set; }
        public string CardNumber { get; set; }
        public int CVC { get; set; }
        public decimal Balance { get; set; }
        public List<AvialableWorker> AvialableWorkers { get; set; }    }
}
