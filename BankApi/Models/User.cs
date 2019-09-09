using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApi.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IDCardNumber { get; set; }
        public string IDcardFincode { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }

    }
}
