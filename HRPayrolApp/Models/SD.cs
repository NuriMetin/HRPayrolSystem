using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models
{
    
    public static class SD
    {
        public enum Roles
        {
            HR,
            Admin,
            PayrollSpecalist,
            Worker,
            DepartmentHead
        }
        public const string HR = "HR";
        public const string Admin = "Admin";
        public const string PayrollSpecalist = "PayrollSpecalist";
        public const string DepartmentHead = "DepartmentHead";
        public const string Worker = "Worker";



        public enum BonusForm
        {
            Percent,
            Amount
        }
        public const string Percent = "Percent";
        public const string Amount = "Amount";
    }
}
