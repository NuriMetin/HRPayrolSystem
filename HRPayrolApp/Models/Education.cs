using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models
{
    public class Education
    {
        [Required]
        [Key]
        public int EducationId { get; set; }

        [Required]
        public string EducationName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
