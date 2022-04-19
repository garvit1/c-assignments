using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serializarion
{ 
    [Serializable]
    class Manager
    {
        public int empId;
        public string empName;
        public double basicSalary;
        public Manager(int empId, string empName, double basicSalary)
        {
            this.empId = empId;
            this.empName = empName;
            this.basicSalary = basicSalary;
        }
        public int getEmpId()
        {
            return empId;
        }
        public string getEmpName()
        {
            return empName;
        }
        public double getEmpSalary()
        {
            return basicSalary;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee ID");
            int empId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary");
            double basicSalary = double.Parse(Console.ReadLine());

            Manager manager1 = new Manager(empId, empName, basicSalary);

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"c:\Sample.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, manager1);
            stream.Close();

            stream = new FileStream(@"c:\Sample.txt", FileMode.Open, FileAccess.Read);
            Manager manager2 = (Manager)formatter.Deserialize(stream);

            Console.WriteLine("---Employee Details---");
            Console.WriteLine(manager2.getEmpId());
            Console.WriteLine(manager2.getEmpName());
            Console.WriteLine(manager2.getEmpSalary());
            Console.ReadKey();
        }
    }
}
