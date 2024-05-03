using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> bankAccount1 = new BankAccount<int>();
            bankAccount1.Input();
            BankAccount<string> bankAccount2 = new BankAccount<string>();
            bankAccount2.Input();
            bankAccount1.GetInfo();
            bankAccount2.GetInfo();
            Console.ReadKey();
        }
    }
}
