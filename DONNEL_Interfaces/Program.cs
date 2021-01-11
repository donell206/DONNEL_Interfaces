using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DONNEL_Interfaces.Models;
using DONNEL_Interfaces.Interfaces;

namespace DONNEL_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            ITransaction transaction = new Transaction();

            transaction.ShowTransaction();
            transaction.GetAmount();
            transaction.ShowBankName();

            Console.WriteLine("---------------------");

            transaction.ShowTransaction();
            transaction.GetAmount();
            transaction.ShowBankName();

            Console.WriteLine("---------------------");

        }
    }
}
