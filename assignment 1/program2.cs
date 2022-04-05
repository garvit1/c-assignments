using System;
using System.Linq;

public class HighestMarks
{
    public static void Main()
    {
        int[] arr = new int[5]; 
        int i;
            
            Console.WriteLine("Enter the Avg Marks of 5 Students");
            for( i=0;i<5;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int maxx= arr.Max();
          
            Console.WriteLine("The maximum marks is {0}",maxx);
            Console.ReadKey();
        }
    }
