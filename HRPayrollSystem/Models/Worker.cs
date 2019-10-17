﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrollSystem.Models
{
    public class Worker: IdentityUser
    {
        [Required]
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        [Required]
        public DateTime BeginDate { get; set; }

        public string PassText { get; set; }
        public string Account { get; set; }

        public virtual ICollection<WorkerAbsens> WorkerAbsens { get; set; }

        [Required]
        public int PositionId { get; set; }
        public virtual Position Position { get; set; }

        public virtual ICollection<WorkerBonus> WorkerBonus { get; set; }

        public virtual Store Store { get; set; }
        public int? StoreId { get; set; }

        public bool Working { get; set; }

        public virtual ICollection<Vacation> Vacations { get; set; }
    }
}
