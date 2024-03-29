﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrollSystem.Models
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
