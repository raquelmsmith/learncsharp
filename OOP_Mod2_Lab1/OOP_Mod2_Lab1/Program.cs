using System;

namespace OOP_Mod2_Lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var employee1 = new TechnicalEmployee("Libby");
            var employee2 = new TechnicalEmployee("Zaynah");
            var employee3 = new BusinessEmployee("Winter");

            Console.WriteLine(employee1.employeeStatus());
            Console.WriteLine(employee2.employeeStatus());
            Console.WriteLine(employee3.employeeStatus());
        }
    }
}
