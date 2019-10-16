using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrollSystem.Models
{
    public class Store
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public virtual ICollection<Worker> Workers { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
