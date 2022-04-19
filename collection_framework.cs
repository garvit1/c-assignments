using System;
using System.Collections.Generic;

public class SystemArray
{
    public static void Main(string[] args)
    {
        int [] src = {8,6,4,2,3,1,5,9,7};
        int n= src.Length;
        
        Console.WriteLine("Original Array :");
        Display(src);
        
        Console.WriteLine("Enter the action ");
        Console.WriteLine("Press 1 for copy");
        Console.WriteLine("Press 2 for Sort");
        Console.WriteLine("Press 3 for reverse");
        Console.WriteLine("Press 4 for clear");
        int num = Convert.ToInt32(Console.ReadLine());
            
            switch(num){
                case 1:
                Console.WriteLine("Enter the number of elements you want to copy");
                int number = Convert.ToInt32(Console.ReadLine());
                int [] dest = new int[10];
                Array.Copy(src,dest,number);
                Display(dest);
                break;
                
                case 2:
                    Array.Sort(src);
                    Display(src);
                    break;
                    
                case 3:
                    Array.Reverse(src);
                    Display(src);
                    break;
                    
                case 4:
                    Array.Clear(src,1,2);
                    Display(src);
                    break;
                
                default:
                    Console.WriteLine("Incorrect action choosed");
                    break;
            }
        }
        
        public static void Display(int[] arr)
            {
                foreach(int i in arr)
                {
                    Console.WriteLine(i);
                }
            }
}
