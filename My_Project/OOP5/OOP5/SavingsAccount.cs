using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class SavingsAccount:BankAccount
    {
        public override void CalculateInterest()
        {
            Console.WriteLine("Savings calculate");
        }
    }
    
}
