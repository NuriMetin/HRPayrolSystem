using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models
{
    public class Salary
    {
        public int ID { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public DateTime CalculatedDate { get; set; }

        public decimal TotalSalary { get; set; }
    }
}
