using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models
{
    public class UnExcusableAbsens
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AbsensId { get; set; }
        public virtual Absens Absens { get; set; }
    }
}
