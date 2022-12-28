using System;

namespace OOP_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine("Enter the Employee Number ");
            emp.EMPNO = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name ");
            emp.EMPNAME = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Employee Salary ");
            emp.SALARY = Convert.ToDouble(Console.ReadLine());
            emp.CalculateEmpDetails();
            emp.DisplayEmpDetails();
            Console.ReadKey();


            
        }
    }
}
