using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models.ViewModels
{
    public class AvialableStores
    {
        [Required]
        public int StoreId { get; set; }
        public IEnumerable<Store> Stores { get; set; }

        [Required]
        public decimal SaleSalary { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public DateTime SelectedDate { get; set; }

        [Required]
        public string StoreName { get; set; }
    }
}
