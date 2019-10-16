using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrollSystem.Models
{
    public class Sale
    {
        public int ID { get; set; }
        public decimal SaleSalary { get; set; }
        public DateTime Date { get; set; }

        public int StoreId { get; set; }
        public virtual Store Store { get; set; }
    }
}
