using System;
namespace UProgram
{
    public class College
    {
        private string name;
        private object degree;

        public string Name {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public object Degree
        {
            get
            {
                return degree;
            }
            set
            {
                degree = value;
            }
        }

        public College(string name)
        {
            this.Name = name;

        }
    }
}
