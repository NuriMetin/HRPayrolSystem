using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrollSystem.Models.ViewModels
{
    public class RoleVM
    {
        public string WorkerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string RoleName { get; set; }

        public string SelectedRole { get; set; }
        public IEnumerable<IdentityRole> Roles { get; set; }
    }
}
