using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrollSystem.Models
{
    public class CompanyWorkPlaceBonus
    {
        public string ID { get; set; }

        public string CompanyWorkPlaceId { get; set; }
        public virtual CompanyWorkPlace CompanyWorkPlace { get; set; }

        public decimal BonusSalary { get; set; }
    }
}
