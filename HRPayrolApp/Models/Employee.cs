using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string FatherName { get; set; }

        public virtual ICollection<CompanyWorkPlace> CompanyWorkPlaces { get; set; }

        [Required]
        public DateTime Born { get; set; }

        [Required]
        public string Residence { get; set; }

        [Required]
        public string DistrictRegistration { get; set; }

        [Required]
        public string PersonalityCardNumber { get; set; }

        [Required]
        public DateTime PersonalityCardEndDate { get; set; }

        public virtual Worker Worker { get; set; } //Clasa cixart


        [Required]
        public int MaritalStatusId { get; set; }
        public virtual MaritalStatus MaritalStatus { get; set; }

        [Required]
        public int GenderId { get; set; }
        public virtual Gender Gender { get; set; }


        [Required]
        public int EducationId { get; set; }
        public virtual Education Education { get; set; }

        public virtual ICollection<WorkPlace> WorkPlaces { get; set; }

        public string Image { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
