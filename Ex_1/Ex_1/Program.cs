﻿using System;
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
            Check checkHusband = new Check();
            Console.Write("Номер счета: ");
            Check.newNumber();
            Console.WriteLine(checkHusband.getNumber());
            checkHusband.setBalance(1000);
            Console.WriteLine("Баланс на счету: {0} рублей", checkHusband.getBalance());
            checkHusband.PrintType(Check._Type.Husband);

            Check checkWife = new Check();
            Check.newNumber();
            Console.Write("Номер счета: ");
            Console.WriteLine(checkWife.getNumber());
            checkWife.setBalance(2000);
            Console.WriteLine("Баланс на счету: {0} рублей", checkWife.getBalance());
            checkWife.PrintType(Check._Type.Wife);



            Console.ReadKey(true);
        }
    }
}
