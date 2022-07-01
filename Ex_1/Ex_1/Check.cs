using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    public enum Type { Wife, Husband };
    public class Check
    {
        public static int _number;
        private int _balance;
        private Type _type;
        public Check()
        {
            newNumber();
            _balance = 1000;
            PrintType(Type.Wife);

        }
        public Check(int balance)
        {
            newNumber();
            _balance = balance;
        }
        public Check(Type type)
        {
            newNumber();
            this._type = type;
            _balance = 20000;
        }
        public Check(Type type, int balance)
        {
            newNumber();
            this._type = type;
            _balance = balance;
        }
       
        
        public void PrintType(Type type)
        {
            switch (type)
            {
                case Type.Husband:
                    Console.WriteLine("Счет мужа");
                    break;
                case Type.Wife:
                    Console.WriteLine("Счет жены");
                    break;
            }
        }
        public static void newNumber()
        {
            _number++;
        }
        public int getNumber()
        {
            return _number;
        }
        public int getBalance()
        {
            return _balance;
        }
    }
}
