﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models
{
    public class Absens
    {
        public int ID { get; set; }
        public string Name { get; set; }  
        
        public virtual ICollection<WorkerAbsens> WorkerAbsens { get; set; }
    }
}
