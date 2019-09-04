using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models
{
    public class WorkerCompanyWorkPlace
    {
        public int ID { get; set; }
        public string WorkerId { get; set; }
        public virtual Worker Worker { get; set; }

        public int CompanyWorkPlaceId { get; set; }
        public virtual CompanyWorkPlace CompanyWorkPlace { get; set; }
    }
}
