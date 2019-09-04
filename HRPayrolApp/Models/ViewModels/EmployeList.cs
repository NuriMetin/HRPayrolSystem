using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models.ViewModels
{
    public class EmployeList
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string FatherName { get; set; }

        public string DistrictRegistration { get; set; }

        public DateTime Born { get; set; }

        public string Residence { get; set; }

        public string PersonalityCardNumber { get; set; }

        public DateTime PersonalityCardEndDate { get; set; }

        public string OldWorkPlaces { get; set; }

        public string Education { get; set; }

        public string Gender { get; set; }

        public string MaritalStatus { get; set; }

        public string Image { get; set; }
    }
}
