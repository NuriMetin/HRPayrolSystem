using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models.ViewModels
{
    public class WorkersViewModel
    {
        public string WorkerId { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public DateTime OldCalcdate { get; set; }
        public decimal TotalSalary { get; set; }
        public DateTime CalculatedDate { get; set; }
        public string Department { get; set; }
        public IEnumerable<Employee> Employees{ get; set; }
        public int SelectedEmployee { get; set; }

        public IEnumerable<Position> Positions { get; set; }
        public int SelectedPosition { get; set; }

        public DateTime BeginDate { get; set; }

        public IEnumerable<Department> Departments { get; set; }
        public int SelectedDepartment { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public DateTime ChangedPositionDate { get; set; }

        public List<AvialableWorker> AvialableWorkers { get; set; }
    }
}
