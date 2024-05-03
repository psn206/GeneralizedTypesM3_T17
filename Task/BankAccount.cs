using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class BankAccount<T>
    {
        T number;
        double balance;
        string ownerIsName;

        public BankAccount()
        {

        }

        public BankAccount(T number, double balance, string ownerIsName)
        {
            this.Number = number;
            this.Balance = balance;
            this.ownerIsName = ownerIsName;
        }

        public T Number { get => number; set => number = value; }
        public double Balance { get => balance; set => balance = value; }
        public string OwnerIsName { get => ownerIsName; set => ownerIsName = value; }

        public void GetInfo()
        {
            Console.WriteLine($"Номер счета: {Number}\nБаланс: {Balance}\nФИО: {OwnerIsName}");
        }

        public void Input()
        {
            Console.WriteLine("Введите номер счета");
            Number = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите баланс");
            Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введиет ФИО");
            OwnerIsName = Console.ReadLine();
        }

    }
}
