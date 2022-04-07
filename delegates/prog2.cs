using System;

namespace EmployeeManagement
{
    interface IPrintable
    {
        void DisplayEmployeeDetails();
    }
    class Employee : IPrintable
    {
        protected string firstName, lastName, designation, address;
        protected float netSalary, grossSalary;

        protected Employee()
        {
            this.firstName = "";
            this.lastName = "";
            this.designation = "";
            this.netSalary = 0.0F;
            this.grossSalary = 0.0F;
            this.address = "";
        }

        protected Employee(string fName, string lName, string designation, float salary, string address)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.designation = designation;
            this.netSalary = salary;
            this.address=address;
        }

        public virtual void CalculateSalary()
        {
            // empty function for overriding
        }
        public void DisplayAddress()
        {
            Console.Write("ADDRESS: {0}\n\n\n", this.address);
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("EMPLOYEE DETAILS:\n");
            Console.WriteLine("Name: {0} {1}", this.firstName, this.lastName);
            Console.WriteLine("Designation: {0}", this.designation);
            Console.WriteLine("Net Salary: {0}", this.netSalary);
            Console.WriteLine("Gross Salary: {0}", this.grossSalary);
            
        }
    }

    class Manager : Employee
    {
        private float petrolAllowance, foodAllowance, otherAllowance;

        public Manager(string fName, string lName, string designation, float salary, string address) : base(fName, lName, designation, salary,address)
        {
            this.petrolAllowance = 0.08F;
            this.foodAllowance = 0.13F;
            this.otherAllowance = 0.03F;
        }

        public override void CalculateSalary()
        {
            grossSalary = (1 + petrolAllowance + foodAllowance + otherAllowance) * netSalary;

        }
    }

    class MarketingExecutive : Employee
    {
        private float kilometerTravel, tourAllowance;
        private int telephoneAllowance;

        public MarketingExecutive(string fName, string lName, string designation, float salary,string address, float kilometers) : base(fName, lName, designation, salary, address)
        {
            this.kilometerTravel = kilometers;
            tourAllowance = 5 * this.kilometerTravel;
            telephoneAllowance = 1000;
        }

        public override void CalculateSalary()
        {
            grossSalary = netSalary + tourAllowance + telephoneAllowance;
        }
    }

    class EmployeeManagementMain
    {
        public delegate void employee();
        static void Main()
        {
            Employee obj1,obj2;
           
            obj1 = new Manager("Garvit", "Khandelwal", "Manager", 1000000, "abc");
            employee emp1 = new employee(obj1.DisplayEmployeeDetails);
            obj1.CalculateSalary();
            emp1();

            obj2 = new MarketingExecutive("ABC", "JAMES", "Marketing Executive", 200000,"Marketing Colony", 10);
            employee emp2 = new employee(obj2.DisplayEmployeeDetails);
            obj2.CalculateSalary();
            emp2 += obj2.DisplayAddress;
            emp2();
        }
        
    }
}
