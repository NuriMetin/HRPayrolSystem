using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models
{
    public class Absens
    {
        public int ID { get; set; }
        public virtual ICollection<WorkerAbsens> WorkerAbsens { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<ExcusableAbsens> ExcusableAbsens { get; set; }
        public virtual ICollection<UnExcusableAbsens> UnExcusableAbsens { get; set; }
    }
}
