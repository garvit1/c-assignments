using System;

namespace LitwareLib
{
  public class Employee:System.Exception
  {
    int EmpNo;
    string EmpName;
    double Salary, HRA, TA, DA, PF, TDS, NetSalary, GrossSalary;
    int flag =0;


    void input ()
    {
      Console.WriteLine ("Enter Employee Number: ");
      EmpNo = Int32.Parse (Console.ReadLine ());
      Console.WriteLine ("Enter Employee Name: ");
      EmpName = Console.ReadLine ();
      try
      {
	    Console.WriteLine ("Enter Employee Salary: ");
	    Salary = Convert.ToDouble (Console.ReadLine ());
      }
      catch (FormatException e)
        {
            Console.WriteLine(e.Message);
            
        }
        finally
        {
            flag = 1;
        }
        


    }



    int CalculateSalary ()
    {
        
      if (Salary < 5000)
	{
	  HRA = 0.1 * Salary;
	  TA = 0.5 * Salary;
	  DA = 0.15 * Salary;

	}
      else if (Salary >= 5000 && Salary < 10000)
	{
	  HRA = 0.15 * Salary;
	  TA = 0.1 * Salary;
	  DA = 0.2 * Salary;

	}
      else if (Salary >= 10000 && Salary < 15000)
	{
	  HRA = 0.2 * Salary;
	  TA = 0.15 * Salary;
	  DA = 0.25 * Salary;

	}
      else if (Salary >= 15000 && Salary < 20000)
	{
	  HRA = 0.25 * Salary;
	  TA = 0.20 * Salary;
	  DA = 0.30 * Salary;

	}
      else if (Salary >= 20000)
	{
	  HRA = 0.3 * Salary;
	  TA = 0.25 * Salary;
	  DA = 0.35 * Salary;

	}

      GrossSalary = Salary + HRA + TA + DA;
      PF = 0.1 * GrossSalary;
      TDS = 0.18 * GrossSalary;
      NetSalary = GrossSalary - (PF + TDS);

      Console.WriteLine ("Gross Salary {0}", GrossSalary);
      Console.WriteLine ("PF {0}", PF);
      Console.WriteLine ("TDS {0}", TDS);
      Console.WriteLine ("NetSalary {0}", NetSalary);
      return 0;
    }


    static void Main (string[]args)
    {
      Employee Emp = new Employee ();
      Emp.input ();
      if(Emp.flag==0)
      Emp.CalculateSalary ();
    }
  }

}
