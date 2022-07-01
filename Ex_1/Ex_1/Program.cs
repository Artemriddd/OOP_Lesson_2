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
            Check checkDefault = new Check();
            Console.Write("Номер счета: ");
            Console.WriteLine(checkDefault.getNumber());
            Console.WriteLine("Баланс на счету: {0} рублей\n", checkDefault.getBalance());

            Check checkOverLoad1 = new Check(100);
            checkOverLoad1.PrintType(Type.Husband);
            Console.Write("Номер счета: ");
            Console.WriteLine(checkOverLoad1.getNumber());
            Console.WriteLine("Баланс на счету: {0} рублей\n", checkOverLoad1.getBalance());


            Check checkOverLoad2 = new Check(Type.Husband,2000);
            checkOverLoad2.PrintType(Type.Husband);
            Console.Write("Номер счета: ");
            Console.WriteLine(checkOverLoad2.getNumber());
            Console.WriteLine("Баланс на счету: {0} рублей\n", checkOverLoad2.getBalance());
 


            Console.ReadKey(true);
        }
    }
}


