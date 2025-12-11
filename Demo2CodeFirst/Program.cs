using Demo2CodeFirst.Data;
using Demo2CodeFirst.Models;

namespace Demo2CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DemoContext dbContext = new DemoContext();

           var res= dbContext.Students.FirstOrDefault(s => s.stdId == 3);

            Console.WriteLine(res.ToString());
            //dbContext.Departments.Add(new Department { DeptName = "KiroTest", DepartmentId=5 });
            //dbContext.SaveChanges();
            //var result = dbContext.Students.Select(std => std.stdName);

            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);
            //} dbContext.Students.Add(new Student { stdName = "kiro",Age=20,DeptNo=5});

            Console.WriteLine("Hello, World!");
        }
    }
}
