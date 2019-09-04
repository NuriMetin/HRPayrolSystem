using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models.ViewModels
{
    public class Test
    {
        public List<EmployeeViewModel> employees;
        public IEnumerable<Gender> Genders { get; set; }
        [Required]
        public int SelectedGender { get; set; }

        public IEnumerable<MaritalStatus> Maritals { get; set; }
        [Required]
        public int SelectedMarital { get; set; }

        public List<Education> Educations;
        public int SelectedEducation { get; set; }
    }
}
