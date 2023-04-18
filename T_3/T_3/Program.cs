using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("plese input your number : ");
            int x=Convert.ToInt32(Console.ReadLine());
            switch (x) 
            {
                case 1:
                    Console.WriteLine("hello");
                    break;
                case 2:
                    Console.WriteLine("goodbye");
                    break;
                 default: 
                    Console.WriteLine("bye");
                    break;
            }
        }
    }
}
