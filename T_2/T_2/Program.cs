using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("plese input your number : ");
            int x=Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                Console.WriteLine("hello");
            }
            else if (x == 2) 
            {
                Console.WriteLine("goodbye");
            }
            else 
            {
                Console.WriteLine("bye");
            }
        }
    }
}
