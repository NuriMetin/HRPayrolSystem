using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrollSystem.Models
{
    public class Gender
    {
        [Required]
        public int GenderId { get; set; }

        [Required(ErrorMessage = "Gender isn't selected!!")]
        public string GenderName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
