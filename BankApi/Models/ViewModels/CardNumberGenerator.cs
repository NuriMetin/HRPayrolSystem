using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApi.Models.ViewModels
{
    public class CardNumberGenerator
    {
        public Int32 RandomNumber(Int32 min, Int32 max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
