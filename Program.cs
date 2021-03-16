using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();
            DateTime date = DateTime.Now;
            Console.WriteLine($"Привет, {name}, сейчас {date}");

            Console.ReadKey();
        }
    }
}
