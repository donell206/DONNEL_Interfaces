using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DONNEL_Interfaces.Models
{
    public class Bank
    {
      
        public readonly string BankName = "Bank of future";
        public readonly string Address = "Brussel";

        public Bank(string bankName, string address)
        {
            BankName = bankName;
            Address = address;
        }
    }
}
