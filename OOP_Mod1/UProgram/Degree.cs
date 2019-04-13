using System;
using System.Collections.Generic;
namespace UProgram
{
    public class Degree
    {
        private string name;
        private List<Course> courses = new List<Course>();
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

        public Degree(string name)
        {
            this.Name = name;
        }
        public void AddCourse(Course course)
        {
            this.courses.Add(course);
        }
        public List<Course> GetCourses()
        {
            return this.courses;
        }
    }
}
