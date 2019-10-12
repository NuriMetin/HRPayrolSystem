using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models
{
    public class Store
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual Company Company { get; set; }
        public int CompanyId { get; set; }
    }
}
