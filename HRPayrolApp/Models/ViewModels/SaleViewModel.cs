using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models.ViewModels
{
    public class SaleViewModel
    {
        [Required]
        public int StoreId { get; set; }
        public IEnumerable<Store> Stores { get; set; }

        public List<AvialableStores> AvialableStores { get; set; }
    }
}
