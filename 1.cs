using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int x=Convert.ToInt32(Console.ReadLine());
        int y=Convert.ToInt32(Console.ReadLine());
       Double z= Math.Abs((Math.Pow(x, y) - Math.Sqrt(Math.Abs(x))) / (Math.Abs(y) + x));
        Console.WriteLine(z);
    }
}