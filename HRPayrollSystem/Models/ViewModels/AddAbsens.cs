using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrollSystem.Models.ViewModels
{
    public class AddAbsens
    {
        [Required]
        public string WorkerId { get; set; }

        public string WorkerAccount { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Reason { get; set; }

        [Required]
        public int SelectedAbsens { get; set; }
        public IEnumerable<Absens> Absens { get; set; }

        public int AbsensId { get; set; }
    }
}
