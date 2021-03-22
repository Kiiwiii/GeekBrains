using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Вывести среднесуточную температуру.
            double t_min, t_max;
            Console.WriteLine("__________________________________");
            Console.WriteLine("Задача 1. Определение среднесуточной температуры");
            Console.WriteLine("__________________________________");

            Console.WriteLine("Введите минимальную температуру:");
            t_min = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру:");
            t_max = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Среднясуточная температура:");
            Console.WriteLine((t_min + t_max) / 2);

            //Задача 2. Определить наименование месяца по его числу.
            Console.WriteLine("__________________________________");
            Console.WriteLine("Задача 2. Определение наименования месяца по его числу");
            Console.WriteLine("__________________________________");

            Console.WriteLine("Введите число месяца:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            switch (month)
            {
                case 1:
                    Console.WriteLine("Месяц: январь");
                    break;
                case 2:
                    Console.WriteLine("Месяц: февраль");
                    break;
                case 3:
                    Console.WriteLine("Месяц: март");
                    break;
                case 4:
                    Console.WriteLine("Месяц: апрель");
                    break;
                case 5:
                    Console.WriteLine("Месяц: май");
                    break;
                case 6:
                    Console.WriteLine("Месяц: июнь");
                    break;
                case 7:
                    Console.WriteLine("Месяц: июль");
                    break;
                case 8:
                    Console.WriteLine("Месяц: август");
                    break;
                case 9:
                    Console.WriteLine("Месяц: сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Месяц: октябрь");
                    break;
                case 11:
                    Console.WriteLine("Месяц: ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Месяц: декабрь");
                    break;
            }

            //Задача 3. Определить четность числа.
            Console.WriteLine("__________________________________");
            Console.WriteLine("Задача 3. Определение четности числа");
            Console.WriteLine("__________________________________");

            Console.WriteLine("Введите число:");
            int i;
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            if (i % 2 == 0)
            {
                Console.WriteLine("Ответ: число четное");
            }
            else
            {
                Console.WriteLine("Ответ: число нечетное");
            }

            //Задача 5*. 
            Console.WriteLine("__________________________________");
            Console.WriteLine("Задача 5*. ");
            Console.WriteLine("__________________________________");

            double tp_min, tp_max, middle;
            Console.WriteLine("Введите число месяца от 1 до 12:");
            month = int.Parse(Console.ReadLine());
            if ( month == 11 || month == 12 || month == 1 )
            {
                Console.WriteLine("Введите минимальную температуру:");
                tp_min = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите максимальную температуру:");
                tp_max = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("----------------------------------");
                Console.WriteLine("Среднясуточная температура:");
                middle = tp_min + tp_max / 2;

                Console.WriteLine(middle);
                Console.WriteLine("----------------------------------");
                if (month >= 11 || month == 1 && middle > 0)
                {
                    Console.WriteLine("Дождливая зима");
                }
                else if (month >= 11 || month == 1 && middle < 0)
                {
                    Console.WriteLine("Морозная зима");
                }
                else
                {
                    Console.WriteLine("Не зимнее время года");
                }
            }
            else
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Введеное число не соответствует диапозону от 1 до 12.");
            }
            



            //Дополнительная задача. Вывести обратную последовательность введенных чисел.
            Console.WriteLine("__________________________________");
            Console.WriteLine("Дополнительная задача.");
            Console.WriteLine("__________________________________");

            int n;
            Console.WriteLine("Введите число:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Обратная последовательность числа:");
            Console.Write(n % 10);
            while ((n /= 10) != 0)
            Console.Write(n % 10);

            Console.Read();
        }
    }
}
