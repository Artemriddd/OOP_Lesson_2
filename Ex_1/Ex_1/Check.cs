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
        private decimal _balance;
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
        public decimal balance
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

        public void AddMoney(decimal money)
        {
            Console.WriteLine($"Пополнение баланса на {money} рублей");
            balance += money;
        }
        public void LostMoney(decimal money)
        {
            if (balance - money >= 0)
            {
                Console.WriteLine($"Покупка на {money} рублей");
                balance -= money;
            }
            else
            {
                Console.WriteLine($"Покупка на {money} рублей");
                Console.WriteLine("Недостаточно средств");
            }
        }

    }
}
