using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models
{
    public class CompanyWorkPlace 
    {
        public int ID { get; set; }
        public string WorkerId { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<WorkerCompanyWorkPlace> WorkerCompanyWorkPlaces { get; set; }

        public string PassText { get; set; }

        public virtual ICollection<Bonus> Bonus { get; set; }

        public virtual ICollection<Escape> Escapes { get; set; }

        public virtual ICollection<WorkerDismiss> WorkerDismisses { get; set; }


        public int PositionId { get; set; }
        public virtual Position Position { get; set; }

        public virtual ICollection<OldWorkPlace> OldWorkPlaces { get; set; }
        
    }
}
