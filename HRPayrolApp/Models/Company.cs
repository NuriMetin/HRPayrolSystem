using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models
{
    public class Company
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Department> Departments { get; set; }

        public virtual ICollection<Store> Stores { get; set; }
    }
}
