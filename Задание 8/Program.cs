using System;

namespace Задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше число");
            double x;
            x = double.Parse(Console.ReadLine());
            double y = 7 + x * (-1 + x * (2 + x * (-5 + 3 * x)));
            Console.WriteLine("Ответ: " + y);
        }
    }
}
