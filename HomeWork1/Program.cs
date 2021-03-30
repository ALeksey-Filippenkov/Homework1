using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя:");
            string name = Console.ReadLine();

            Console.Write($"Привет, {name}, сегодня {DateTime.Now.ToShortDateString()}");
            Console.ReadKey();
        }
    }
}
