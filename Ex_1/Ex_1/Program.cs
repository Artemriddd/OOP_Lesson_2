using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Check checkOne = new Check();
            checkOne.balance = 100;
            checkOne.number = 1;
            checkOne.type = Type.Husband;
            checkOne.PrintType(checkOne.type);
            Console.WriteLine($"Баланс = {checkOne.balance} рублей");
            Console.WriteLine($"Номер счета: {checkOne.number}\n");
            checkOne.AddMoney(1000);
            Console.WriteLine($"Баланс = {checkOne.balance} рублей\n");
            checkOne.LostMoney(1000);
            Console.WriteLine($"Баланс = {checkOne.balance} рублей\n");
            checkOne.LostMoney(1000);
            Console.WriteLine($"Баланс = {checkOne.balance} рублей\n");

            Console.ReadKey(true);
        }
    }
}


