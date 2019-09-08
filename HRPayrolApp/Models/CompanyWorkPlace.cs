using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models
{
    public class CompanyWorkPlace 
    {
        public string ID { get; set; }
      
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
       
        public DateTime ChangedDate { get; set; }

        public virtual ICollection<CompanyWorkPlaceBonus> CompanyWorkPlaceBonus { get; set; }

        public virtual ICollection<CompanyWorkPlaceAbsens> CompanyWorkPlaceAbsens { get; set; }

        public virtual ICollection<WorkerDismiss> WorkerDismisses { get; set; }


        public int PositionId { get; set; }
        public virtual Position Position { get; set; }

        
        
    }
}
