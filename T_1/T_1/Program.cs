using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("plese input your number : ");
            int x=Convert.ToInt32(Console.ReadLine());
            if(x>0) 
            {
                Console.WriteLine("this number is Positive");
            }
            else if(x==0) 
            {
                Console.WriteLine("this number is Zero");
            }
            else
            {
                Console.WriteLine("this number is Negative");
            }
            }
    }
}
