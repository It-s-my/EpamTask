using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._3.ANOTHER_TRIANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int N_Space = n - i - 1;
                int N_Star = 1 + i * 2;
                string Space = new string(' ', N_Space);
                Console.WriteLine(Space + new string('*', N_Star) + Space);

            }
            Console.ReadLine();
        }
    }
}
