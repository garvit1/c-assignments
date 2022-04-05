using System;
using System.Linq;
  
class ParamArray {   
    
    public static void Main() 
    {
        Console.WriteLine("Enter the number of elements: ");
        int n= Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter the numbers: ");
        for(int i=0; i<n; i++)
        {
            arr[i]= Convert.ToInt32(Console.ReadLine());
        } 
        Console.WriteLine("Sum of given array is {0}", sum(arr));
    }
    public static int sum(params int[] arr)
    { 
        int sum = arr.Sum();
                 
        return sum;
    }
      
  
}
