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

            Check checkTwo = new Check();
            checkTwo.balance = 2000;
            checkTwo.number = 2;
            checkTwo.type = Type.Wife;
            checkOne.PrintType(checkTwo.type);
            Console.WriteLine($"Баланс = {checkTwo.balance} рублей");
            Console.WriteLine($"Номер счета: {checkTwo.number}\n");

            Console.ReadKey(true);
        }
    }
}


