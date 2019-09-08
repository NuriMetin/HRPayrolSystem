using HRPayrolApp.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models
{
    public class Worker : IdentityUser
    {
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        //public virtual ICollection<WorkerCompanyWorkPlace> CompanyWorkPlaces { get; set; }

        public DateTime BeginDate { get; set; }

        public string PassText { get; set; }
        public string Account { get; set; }

        public virtual ICollection<Escape> Escapes { get; set; }

        public virtual ICollection<WorkerDismiss> WorkerDismisses { get; set; }


        public int PositionId { get; set; }
        public virtual Position Position { get; set; }

        public virtual ICollection<OldWorkPlace> OldWorkPlaces { get; set; }

        public virtual ICollection<WorkerBonus> WorkerBonus { get; set; }
    }
}
