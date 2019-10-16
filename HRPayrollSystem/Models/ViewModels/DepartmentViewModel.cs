using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrollSystem.Models.ViewModels
{
    public class DepartmentViewModel
    {
        public int ID { get; set; }
        public IEnumerable<Company> Companies { get; set; }

        public Company Company { get; set; }

        [Required(ErrorMessage = "Not be empty")]
        public int SelectedCompany { get; set; }

        [Required(ErrorMessage = "Not be empty")]
        public string Name { get; set; }

        public string CompanyName { get; set; }
    }
}
