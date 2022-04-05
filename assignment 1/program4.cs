using System;

namespace Swap
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a ,b;
            Console.WriteLine("Enter the first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            b = Convert.ToInt32(Console.ReadLine());

            Swap(ref a, ref b);
            
            Console.WriteLine("Value of numbers after swapping");
            Console.WriteLine("First Number = {0} ", a);
            Console.WriteLine("Second Number = {0} ",b);
            Console.ReadLine();
        }
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        
    }
}
