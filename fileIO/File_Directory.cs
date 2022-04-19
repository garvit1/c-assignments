using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Createdirectory
{
    class Program
    {
        static void Main(string[] args)
        {
             
            String path = @"D:\MyTestFile1.txt";
            DirectoryInfo fl = new DirectoryInfo(path);
            fl.Create();
            {
                Console.WriteLine("Directory has been created");
            }
  
            String path = @"D:\MyTestFile1.txt";
            DirectoryInfo fl = new DirectoryInfo(path);
            DirectoryInfo dis = fl.CreateSubdirectory("hellotest");
            {
                Console.WriteLine("Sub-Directory has been created");
            }
              
            String path = @"D:\MyTestFile1.txt";
            string path1 = @"D:\NewFile1.txt";
            DirectoryInfo f1 = new DirectoryInfo(path);
            DirectoryInfo f2 = new DirectoryInfo(path1);
            
            f1.MoveTo(path1);
            {
                Console.WriteLine("Directory has been Moved");
            }
  
            string path = @"D:\NewFile1.txt";
            DirectoryInfo f1 = new DirectoryInfo(path);
            f1.Delete();
            {
                Console.WriteLine("Directory has been deleted");
            }
  
            try
            {
                DirectoryInfo di = new DirectoryInfo(@"D:\newFile\");
                DirectoryInfo[] dir1 = di.GetDirectories();
                Console.WriteLine("The number of directories containing is {0}.", dir1.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }

            DirectoryInfo di = new DirectoryInfo(@"D:\newfile");
            DirectoryInfo[] dirs = di.GetDirectories();
            foreach (DirectoryInfo diNext in dirs)
            {
                Console.WriteLine("The number of files in {0} is {1}", diNext,diNext.GetFiles().Length);
            }
        }
    }
}
