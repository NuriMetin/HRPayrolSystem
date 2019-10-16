using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrollSystem.Models
{
    public class Salary
    {
        public int ID { get; set; }

        [Required]
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        [Required]
        public DateTime CalculatedDate { get; set; }

        [Required]
        public decimal TotalSalary { get; set; }
    }
}
