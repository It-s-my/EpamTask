using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._5_SUM_OF_NUMBERS
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    Sum += i;
            }
            Console.WriteLine($"Сумма всех кратных чисел от 1 до 1000: {Sum}");
            Console.ReadLine();
        }
    }
}
