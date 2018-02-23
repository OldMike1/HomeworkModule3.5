using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkModule3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = int.Parse(Console.ReadLine());

            for (int i = Math.Min(a, b); i < Math.Max(a,b); i++)
            {
                if (i%5 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
