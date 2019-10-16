using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrollSystem.Models.ViewModels
{
    public class PositionViewModel
    {
        public int ID { get; set; }
        public IEnumerable<Department> Departments { get; set; }

        public Department Department { get; set; }

        [Required(ErrorMessage = "Not be empty")]
        public int SelectedDepartment { get; set; }

        [Required(ErrorMessage = "Not be empty")]
        public string Name { get; set; }

        public string DepartmentName { get; set; }

        [Required]
        public decimal Salary { get; set; }
    }
}
