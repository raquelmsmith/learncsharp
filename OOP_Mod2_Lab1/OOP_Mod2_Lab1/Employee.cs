using System;
namespace OOP_Mod2_Lab1
{
    abstract class Employee
    {

        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;
        // keep track of the number of employees
        private static int employeeCount = 1;

        public string Name
        {
            get
            {
                return employeeName;
            }
            set
            {
                employeeName = value;
            }
        }

        public double BaseSalary
        {
            get
            {
                return employeeBaseSalary;
            }
            set
            {
                employeeBaseSalary = value;
            }
        }

        public int ID {
            get
            {
                return employeeId;
            }
            set
            {
                employeeId = value;
            }
        }


        public Employee(string name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }

        public double getBaseSalary()
        {
            return this.BaseSalary;
        }

        public string getName()
        {
            return this.Name;
        }
        public int getEmployeeID()
        {
            return this.ID;
        }

        public string toString()
        {
            return this.ID + " " + this.Name;
        }

        public abstract string employeeStatus();
    }
}
