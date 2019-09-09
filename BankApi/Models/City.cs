using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApi.Models
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        
        public int CountryId { get; set; }
        public virtual Coutry Coutry { get; set; }
    }
}
