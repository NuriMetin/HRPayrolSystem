using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models
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
