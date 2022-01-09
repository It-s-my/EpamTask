using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._1_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int S;
            Console.WriteLine("Введите значение а:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 0 || a == 0)
            {
                Console.WriteLine("Ошибка.Попробуйте Ввести другое значение а");
                a = Convert.ToInt32(Console.ReadLine());
            }
                Console.WriteLine("Введите значение b:");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b < 0 || b == 0){
                Console.WriteLine("Ошибка.Попробуйте Ввести другое значение b");
                b = Convert.ToInt32(Console.ReadLine());
                 }
            if (a < 0 || a == 0)
            {
                Console.WriteLine("Неверно введены данные");
                Console.ReadKey();
            }
            else if (b < 0 || b == 0)
            {
                Console.WriteLine("Неверно введены данные");
                Console.ReadKey();
            }
            else
            {
                S = a * b;
                Console.WriteLine($"Сторона а: {a} Сторона b: {b} Площадь прямоугольника S: {S}");
                Console.ReadKey();
            }
        }
    }
}
