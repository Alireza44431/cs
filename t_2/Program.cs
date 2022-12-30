using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inter number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("inter number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("inter number : ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a + c > b && a + b > c && b + c > a)
                Console.WriteLine($"the triangle is formed with the primeter of => '{Perimeter(a, b, c)}'");
            else
                Console.WriteLine("triangle is not formed");
            Console.ReadKey();
        }
        private static double Perimeter(int a, int b, int c)
        {
            return a + b + c;
        }

        }
}
