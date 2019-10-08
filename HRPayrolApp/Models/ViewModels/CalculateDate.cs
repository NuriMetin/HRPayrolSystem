using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models.ViewModels
{
    public class CalculateDate
    {
        public int ID { get; set; }
       // @Model.AvialableWorkers[i].OldCalculate.Date.ToShortDateString()
        public int EmployeeId { get; set; }
        public DateTime CalcDate { get; set; }
    }
}
