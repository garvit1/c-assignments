
   
using System;
namespace Calculator{
    class Program{
        public static void Main()
        {
            abc:
            Console.WriteLine("1. Addition/n");
            Console.WriteLine("2. Subtraction/n");
            Console.WriteLine("3. Multiplication/n");
            Console.WriteLine("4. Division/n");
            int option = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Both numbers");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            
            switch(option)
            {
                case 1:
                result = Addition(x,y);
                break;
                case 2:
                result = Subtraction(x,y);
                break;
                case 3:
                result = Multiplication(x,y);
                break;
                case 4:
                result = Division(x,y);
                break;
                default:
                Console.WriteLine("Invalid option");
                goto abc;
              
            }
            Console.WriteLine("The Result is {0}", result);
            Console.ReadKey();
        }
        
        
        public static int Addition(int a, int b){
            int result = a+b;
            return result;
        }
         public static int Subtraction(int a, int b){
            int result = a-b;
            return result;
        }
         public static int Multiplication(int a, int b){
            int result = a*b;
            return result;
        }
         public static int Division(int a, int b){
            int result = a/b;
            return result;
        }
    }
}
