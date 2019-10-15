using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApi.Models.ViewModel
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Surname { get; set; } 
        public string IDCardNumber { get; set; }
        public string IDCardFinCode { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
    }
}
