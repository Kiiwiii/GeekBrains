using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Вывести элементы по диагонали.
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Задача 2. Вывод эменетов матрицы по диагонали");
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Введите размерность матрицы");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Вывод по диагонали: ");
            int k = 1; //счётчик,который увеличивается при заполнении массива
            int[,] mas = new int[a, a];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (i == j) mas[i, j] = k;
                    Console.Write(mas[i, j] + " ");
                }
                k++; //свеличение переменной на 1
                Console.WriteLine();
            }

            //Задача 2. Вывести телефонный справочник.
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Задача 2. Телефонный справочник");
            Console.WriteLine("_________________________________________");

            const int row = 5;
            const int col = 2;
            string[,] numbers = new string[row, col] {
                {"Надежда   ","89227808507"},
                {"Эдуард    ","89225487106"},
                {"Екатерина ","89124570022"},
                {"Наталья   ","89130045511"},
                {"Юрий      ","89124788585"},
            };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Задача 3. Вывести строку в обратном порядке.
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Задача 3. Вывод строки в обратном порядке");
            Console.WriteLine("_________________________________________");

            List<string> words = new List<string>();
            string s;
            while (true)
            {
                Console.Write("Введите строку (для вывода обратной послед-ти введите с новой строки: ok):");
                s = Console.ReadLine();
                if (s == "ok")
                    break;
                else
                    words.Add(s);
            }
            for (int i = 0; i < words.Count; i++)
            {
                s = string.Empty;
                for (int j = words[i].Length - 1; j > -1; j--)
                    s += words[i][j];
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Вывод строки в обратном порядке: ");
                Console.WriteLine(s);
            }

            //Задача 4. Вывести массив расположения кораблей
            //Если нужно было создать лагоритм, которые сам расставляет корабли в матрице, то это пока не есть выполнямо для меня :) 
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Задача 4. Массив расположения кораблей");
            Console.WriteLine("_________________________________________");

            const int x = 10;
            const int y = 10;
            string[,] ship = new string[x, y] {
                {"O","O","O","O","Х","O","O","O","O","O"},
                {"O","Х","O","O","Х","O","O","O","O","O"},
                {"O","Х","O","O","O","O","Х","Х","O","O"},
                {"O","O","O","O","O","O","O","O","O","Х"},
                {"O","Х","O","Х","Х","Х","O","O","O","O"},
                {"O","O","O","O","O","O","O","O","Х","O"},
                {"O","O","O","O","O","O","O","O","Х","O"},
                {"O","O","Х","O","O","Х","O","O","Х","O"},
                {"O","O","O","O","O","Х","O","O","Х","O"},
                {"O","Х","O","O","O","Х","O","O","O","O"},
            };

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(ship[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
