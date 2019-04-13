﻿using System;
namespace OOP_Mod2_Lab1
{
    class BusinessEmployee : Employee
    {
        public double bonusBudget = 1000;

        public BusinessEmployee(string name) : base(name, 50000) { }

        public override string employeeStatus()
        {
            return this.toString() + " with a budget of " + this.bonusBudget;
        }
    }
}
