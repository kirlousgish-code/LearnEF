using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo4.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Emp : Person
    {
        public float Salary { get; set; }
    }
    public class Student : Person
    {
        public char Grade { get; set; }
    }

    

}
