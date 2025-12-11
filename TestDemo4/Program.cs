using TestDemo4.Data;
using TestDemo4.Models;

namespace TestDemo4
{
    internal class Program
    {
        static void Main(string[] args)
        {



            TestDemo4Context context = new TestDemo4Context();

            context.Database.EnsureDeleted();

            //var emp = new Emp
            //{
            //    Name = "John Doe",
            //    Age = 30,
            //    Salary = 50000f
            //};

            //var student = new Student
            //{
            //    Name = "Jane Smith",
            //    Age = 20,
            //    Grade = 'A'
            //};
            //context.Emps.Add(emp);
            //context.Students.Add(student);
            //context.SaveChanges();
            Console.WriteLine("Hello, World!");
        }
    }
}
