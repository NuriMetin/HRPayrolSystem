using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrollSystem.Models
{
    public class MaritalStatus
    {
        [Required]
        public int MaritalStatusId { get; set; }

        [Required(ErrorMessage = "Marital status don't be empty!!!")]
        public string MaritalStatusName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
