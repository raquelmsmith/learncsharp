using System;
namespace UProgram
{
    public class Teacher
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

        public Teacher(string name)
        {
            this.Name = name;
        }
    }
}
