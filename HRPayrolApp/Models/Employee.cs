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

        public string Name { get; set; }

        public string Surname { get; set; }

        public string FatherName { get; set; }

        public virtual ICollection<CompanyWorkPlace> CompanyWorkPlaces { get; set; }

        public DateTime Born { get; set; }

        public string Residence { get; set; }

        public string DistrictRegistration { get; set; }

        public string PersonalityCardNumber { get; set; }

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
