using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models.ViewModels
{
    public class Combo
    {
        public IEnumerable<Gender> Genders { get; set; }
        [Required]
        public int SelectedGender { get; set; }

        public IEnumerable<MaritalStatus> Maritals { get; set; }
        [Required]
        public int SelectedMarital { get; set; }

        public IEnumerable<Education> Educations { get; set; }
        public int SelectedEducation { get; set; }
    }
}
