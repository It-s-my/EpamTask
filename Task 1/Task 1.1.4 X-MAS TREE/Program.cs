using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._4_X_MAS_TREE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n+i)/2 ; j++)
                {
                    int N_Space = n - j - 1;
                    int N_Star = 1 + j * 2 ;
                    string Space = new string(' ', N_Space);
                    Console.WriteLine(Space + new string('*', N_Star));
                }
            }
            Console.ReadLine();
        }
    }
}
