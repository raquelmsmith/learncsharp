using System;
namespace UProgram
{
    public class Student
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Student(string name)
        {
            this.Name = name;
        }
    }
}
