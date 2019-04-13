using System;

namespace UProgram
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            College IT = new College("Information Technology");
            Degree WebDev = new Degree("Web Development");
            Course CSharp = new Course("Programming with C#");
            Teacher Jones = new Teacher("Jane Jones");
            Student RSmith = new Student("Raquel Smith");
            Student ASmith = new Student("Andrew Smith");
            Student KSmith = new Student("Kacey Smith");
            WebDev.AddCourse(CSharp);
            CSharp.AddStudent(RSmith);
            CSharp.AddStudent(ASmith);
            CSharp.AddStudent(KSmith);
            CSharp.Teacher = Jones;

            Console.WriteLine($"In the college of {IT.Name} there is a degree for {WebDev.Name} and a course for {CSharp.Name}.");
            Console.WriteLine($"There are {CSharp.GetNumStudents()} students in the class. The class is taught by {CSharp.Teacher.Name}.");

        }
    }
}
