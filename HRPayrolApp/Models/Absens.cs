﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models
{
    public class Absens
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }  
        
        public virtual ICollection<WorkerAbsens> WorkerAbsens { get; set; }
    }
}
