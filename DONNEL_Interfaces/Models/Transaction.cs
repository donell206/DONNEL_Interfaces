using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DONNEL_Interfaces.Interfaces;

namespace DONNEL_Interfaces.Models
{
    public class Transaction:Bank,ITransaction
    {
        private readonly string _code;
        private readonly string _date;
        private readonly double _amount;
        private double _commission;

        public double GetAmount()
        {
            if (_amount>100)
            {
                Console.WriteLine($"You will BE charged with extra comission " + (_amount * _commission));
                return 1;
            }
            else
            {
                Console.WriteLine($"Your Account will not BE charged");
                return 1;
            }
        }


        public void ShowTransaction()
        {
            Console.WriteLine($"{0}/n{1}/n{2}/n{3}/n{4}/n", BankName, Address, _code, _amount);
        }

        public string ShowBankName()
        {
            throw new NotImplementedException();
        }

        public Transaction(string BankName, string Address, string _code, string _date, double _amount, double _commission) : base(BankName, Address)
        {
            Transaction=_code;
            Date = string _date
            Amount: _amount;

            _commission =0,005;

        }

        public Transaction()
        {
        }
    }
