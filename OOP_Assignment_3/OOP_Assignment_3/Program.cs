using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Manager emp = new Manager();
            MarketingExecutive Market = new MarketingExecutive();
            Console.WriteLine("Enter the Employee Number ");
            emp.EMPNO = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name ");
            emp.EMPNAME = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Employee Salary ");
            emp.SALARY = Convert.ToDouble(Console.ReadLine());
            emp.CalculateManagerDetails();
            emp.CalculateEmpDetails();
            emp.DisplayManagerDetails();
            Market.CalculateMarketting();
            Market.CalculateEmpDetails();
            Market.DisplayMarketting();

            Console.ReadKey();


        }
    }
}
