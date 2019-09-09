using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApi.Models
{
    public class Card
    {
        public int ID { get; set; }
        public string CardNumber { get; set; }
        public int CVC { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ValidDate { get; set; }
        public decimal Balans { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
