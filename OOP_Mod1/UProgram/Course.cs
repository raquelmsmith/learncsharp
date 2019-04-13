using System;
using System.Collections.Generic;

namespace UProgram
{
    public class Course
    {
        private string name;
        private Teacher teacher;
        private List<Student> students = new List<Student>();
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
        public Teacher Teacher
        {
            get
            {
                return teacher;
            }
            set
            {
                teacher = value;
            }
        }

        public Course(string name)
        {
            this.Name = name;
        }
        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }
        public int GetNumStudents()
        {
            return this.students.Count;
        }

    }
}
