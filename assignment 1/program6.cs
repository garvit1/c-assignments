using System;

struct book 
{
  public int bookId;
	public string title;
	public double price;
	public string bookType;
}


public class BookStruct
{
  public static void Main ()  
	{
	    Console.WriteLine("Enter the Number of books");
      int noOfBook =Convert.ToInt32(Console.ReadLine());  
      book [] books =new book [noOfBook];  
      int i,j,n=noOfBook,k=1;  
	
			for(j=0;j<n;j++)
				{
			    Console.WriteLine("Information of book {0} :",k);

          Console.Write("Enter the book ID : ");
			    books[j].bookId= Convert.ToInt32(Console.ReadLine());
			    Console.Write("Enter the book title : ");
			    books[j].title= Console.ReadLine();
          Console.Write("Enter the book price : ");
			    books[j].price= Convert.ToDouble(Console.ReadLine());
			    Console.Write("Input the type of book : ");
			    books[j].bookType= Console.ReadLine();
          k++;
			    }

	        for(i = 0;i <n;i++)
	        {
            Console.WriteLine("{0}: Book ID = {1},  Title = {2}, Book Price = {3},  Type of book = {4}", i+1,books[i].bookId, books[i].title, books[i].price, books[i].bookType);
            Console.WriteLine();
	        }

	}
