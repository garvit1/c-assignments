using System;
  
namespace circle  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            Console.WriteLine("Please enter radius for circle");  
            double radius = Convert.ToDouble(Console.ReadLine());  
            double area = 0;
            double circumference ;
            
            CalculateCircle(radius, out area, out circumference);  
            Console.WriteLine("Circle's circumference is {0}",circumference);  
            Console.WriteLine("Circle's Area is {0}",area);  
            Console.ReadKey();  
        }  
  
       static void CalculateCircle(double radius, out double area, out double circumference)  
        {  
            double PI = 3.14;
            area = PI * radius * radius;  
            circumference = 2 * PI * radius;  
        }  
    }  
}
