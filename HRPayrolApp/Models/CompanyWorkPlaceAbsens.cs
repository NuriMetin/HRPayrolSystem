using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models
{
    public class CompanyWorkPlaceAbsens
    {
        public string ID { get; set; }

        public string CompanyWorkPlaceId { get; set; }
        public virtual CompanyWorkPlace CompanyWorkPlace { get; set; }
       
        public int ExcusableAbsens { get; set; }
        public int UnExcusableAbsens { get; set; }
    }
}
