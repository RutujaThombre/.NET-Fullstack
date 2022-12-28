using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment_2
{

    class Employee
    {
        private int EmpNo;
        private string EmpName;
        private double salary;
        private double hra;
        private double ta;
        private double da;
        private double pf;
        private double tds;
        private double NetSalary;
        private double GrossSalary;
        public int EMPNO { get; set; }
        public string EMPNAME { get; set; }
        public double SALARY { get; set; }
        public double HRA { get; set; }
        public double TA { get; set; }
        public double DA { get; set; }
        public double PF { get; set; }
        public double TDS { get; set; }
        public double NETSALARY { get; set; }
        public double GROSSSALARY { get; set; }
        public Employee()
            //(int EmpNo, string EmpName, double salary, double hra, double ta, double da, double pf, double tds, double NetSalary, double GrossSalary)
        {
            this.EMPNO = EmpNo;
            this.EMPNAME = EmpName;
            this.SALARY = salary;
            this.HRA = hra;
            this.TA = ta;
            this.DA = da;
            this.PF = tds;
            this.TDS = tds;
            this.NETSALARY = NetSalary;
            this.GROSSSALARY = GrossSalary;
        }
        public void DisplayEmpDetails()
        {
            Console.WriteLine("The emp no is " + EMPNO);
            Console.WriteLine("The emp name is " + EMPNAME);
            Console.WriteLine("The emp salary is " + SALARY);
            Console.WriteLine("The emp hra is " + HRA);
            Console.WriteLine("The emp ta is " + TA);
            Console.WriteLine("The emp da is " + DA);
            Console.WriteLine("The emp pf is " + PF);
            Console.WriteLine("The emp tds is " + TDS);
            Console.WriteLine("The emp GrossSalary is " + GROSSSALARY);
            Console.WriteLine("The emp NetSalary is " + NETSALARY);

            //Console.WriteLine("The Emp No is " + EMPNO + " The Emp Name is " + EMPNAME + "The Emp Salary is" + SALARY + "The Emp hra is" + HRA + "The Emp ta is" + TA + "The Emp da is" + DA + "The Emp pf is" + PF + "The Emp tds is" + TDS + "The Emp NetSalary is" + NETSALARY + "The Emp GrossSalary is" + GROSSSALARY);
        }
        public void CalculateEmpDetails()
        {
            if (SALARY < 5000)
            {
                HRA = (10 * SALARY) / 100;
                TA = (5 * SALARY) / 100;
                DA = (15 * SALARY) / 100;
                GROSSSALARY = SALARY + HRA + TA + DA;
                PF = (10 * GROSSSALARY) / 100;
                TDS = (18 * GROSSSALARY) / 100;
                NETSALARY = GROSSSALARY - (PF + TDS);

            }
            if (SALARY < 10000)
            {
                HRA = (15 * SALARY) / 100;
                TA = (10 * SALARY) / 100;
                DA = (20 * SALARY) / 100;
                GROSSSALARY = SALARY + HRA + TA + DA;
                PF = (10 * GROSSSALARY) / 100;
                TDS = (18 * GROSSSALARY) / 100;
                NETSALARY = GROSSSALARY - (PF + TDS);

            }
            else if (SALARY < 15000)
            {
                HRA = (20 * SALARY) / 100;
                TA = (15 * SALARY) / 100;
                DA = (25 * SALARY) / 100;
                GROSSSALARY = SALARY + HRA + TA + DA;
                PF = (10 * GROSSSALARY) / 100;
                TDS = (18 * GROSSSALARY) / 100;
                NETSALARY = GROSSSALARY - (PF + TDS);

            }
            else if (SALARY < 20000)
            {
                HRA = (25 * SALARY) / 100;
                TA = (20 * SALARY) / 100;
                DA = (30 * SALARY) / 100;
                GROSSSALARY = SALARY + HRA + TA + DA;
                PF = (10 * GROSSSALARY) / 100;
                TDS = (18 * GROSSSALARY) / 100;
                NETSALARY = GROSSSALARY - (PF + TDS);

            }
            else if (SALARY >= 20000)
            {
                HRA = (30 * SALARY) / 100;
                TA = (25 * SALARY) / 100;
                DA = (35 * SALARY) / 100;
                GROSSSALARY = SALARY + HRA + TA + DA;
                PF = (10 * GROSSSALARY) / 100;
                TDS = (18 * GROSSSALARY) / 100;
                NETSALARY = GROSSSALARY - (PF + TDS);

            }

        }

     }
}
