using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    internal class Check
    {
        public static int _Number;
        private int _Balance;
        public enum _Type { Wife, Husband };

        public void PrintType(_Type type)
        {
            switch (type)
            {
                case _Type.Husband:
                    Console.WriteLine("Счет мужа");
                    break;
                case _Type.Wife:
                    Console.WriteLine("Счет жены");
                    break;
            }
        }

        public static void newNumber()
        {
            _Number++;

        }
        public int getNumber()
        {
            return _Number;
        }
        public void setBalance(int n)
        {
            _Balance = n;
        }
        public int getBalance()
        {
            return _Balance;
        }
    }
}
