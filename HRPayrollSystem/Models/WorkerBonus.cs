using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrollSystem.Models
{
    public class WorkerBonus
    {
        public int ID { get; set; }

        [Required]
        public string WorkerId { get; set; }
        public virtual Worker Worker { get; set; }

        [Required]
        public string Reason { get; set; }

        [Required]
        public DateTime BonusDate { get; set; }

        [Required]
        public decimal BonusSalary { get; set; }
    }
}
