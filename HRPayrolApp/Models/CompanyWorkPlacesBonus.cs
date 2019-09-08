using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models
{
    public class CompanyWorkPlaceBonus
    {
        public string ID { get; set; }

        public string CompanyWorkPlaceId { get; set; }
        public virtual CompanyWorkPlace CompanyWorkPlace { get; set; }

        [Required]
        public decimal BonusSalary { get; set; }
    }
}
