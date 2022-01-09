using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._2_TRIANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= n; i++)
            {
                Console.WriteLine(new string('*', i + 1));
            }
            Console.ReadKey();
        }
    }
}
