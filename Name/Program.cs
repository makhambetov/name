using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше ФИО:");
            string name = Console.ReadLine();
            Console.WriteLine("Приетствую тебя, " + name + "!");

            Console.ReadKey();
        }
    }
}
