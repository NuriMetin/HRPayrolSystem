using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models.ViewModels
{
    public class EmployeeViewModel
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string FatherName { get; set; }

        [Column(TypeName ="date")]
        public DateTime Born { get; set; }

        [Required]
        public string Residence { get; set; }

        [Required]
        public string DistrictRegistration { get; set; }

        [Required]
        [RegularExpression(@"\d{8}",ErrorMessage ="Invalid type. Must be 8 character")]
        public string IDCardNumber { get; set; }

        [Required]
        public string IDCardFinCode { get; set; }

        [Required]
        public string Number { get; set; }

        [Required]
        public string OldWorkPlaces { get; set; }
        
        public IEnumerable<Gender> Genders { get; set; }
        [Required]
        public int SelectedGender { get; set; }

        public IEnumerable<MaritalStatus> Maritals { get; set; }
        [Required]
        public int SelectedMarital { get; set; }

        public IEnumerable<Education> Educations { get; set; }
        public int SelectedEducation { get; set; }

        public string EducationText { get; set; }
        public string GenderText { get; set; }
        public string MaritalStatusText { get; set; }

        
        public string Image { get; set; }

        
        public IFormFile Photo { get; set; }
    }
}
