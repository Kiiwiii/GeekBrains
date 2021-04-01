using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Вывод числа Фибоначчи для заданного значения.
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Задача 1. Вывод ФИО");
            Console.WriteLine("_________________________________________");
            Console.WriteLine(GetGreetingMessage("Чернобай", "Надежда", "Андреевна"));
            Console.WriteLine(GetGreetingMessage("Димура", "Эдуард", "Юрьевич"));
            Console.WriteLine(GetGreetingMessage("Димура", "Екатерина", "Юрьевна"));

            //Задача 2. Вывод суммы всех чисел в строке.
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Задача 2. Введите числа через пробел.");
            Console.WriteLine("_________________________________________");
            int[] str = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Сумма чисел: ");
            Console.WriteLine(str.Sum());
            Console.WriteLine("Нажмите enter.. ");
            Console.ReadKey();

            //Задача 3. Определение времени года.
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Задача 3. Определить время года");
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Введите месяц от 1 до 12:");
            int mount = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Время года: ");
            Check(mount);
            Console.WriteLine("Нажмите enter.. ");
            Console.ReadKey();

            //Задача 4*. Вывод числа Фибоначчи для заданного значения.
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Задача 4*. Вывод числа Фибоначчи для заданного значения");
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Введите число членов последовательности:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Полученное число: ");
            Console.WriteLine(FibRec(n));

            Console.ReadLine();
        }

        //1-е задание
        private static string GetGreetingMessage(string firstName, string lastName, string patronymic)
        {
            return string.Format("{0} {1} {2}", firstName, lastName, patronymic);
        }

        //3-е задание
        public static void Check(int mount)
        {
            if (mount == 1 || mount == 2 || mount == 12)
            {
                Console.WriteLine("Зима ");
            }
            else if (mount >= 3 && mount <= 2)
            {
                Console.WriteLine("Весна ");
            }
            else if (mount >= 6 && mount <= 8)
            {
                Console.WriteLine("Лето ");
            }
            else if (mount >= 9 && mount <= 11)
            {
                Console.WriteLine("Осень ");
            }
        }

        //4-е задание
        public static int FibRec(int n) 
        {
            if (n <= 2)
            {
                return 1;
            }
            else
            {
                return FibRec(n - 1) + FibRec(n - 2);
            }
        }
    }
}
