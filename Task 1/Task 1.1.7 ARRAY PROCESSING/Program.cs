using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._7_ARRAY_PROCESSING
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[5];
            Random(arr);
            
            

            Console.ReadKey();
        }
        private static int[] Random(int[] arr)
        {
            var random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-100, 100);
            }

            return arr;
        }
    }
}
