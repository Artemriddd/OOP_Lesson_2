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
        private int _number;
        private int _balance;
        private Type _type;

        public int number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        public int balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }
        public Type type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
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

    }
}
