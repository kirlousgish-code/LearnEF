using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2CodeFirst.Models
{
    internal class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepartmentId { get; set; }

        [Required]
        [StringLength(20)]
        public required string DeptName { get; set; }


        public string? Capacity { get; set; }

        public List<Student> students { get; set; } = new List<Student>();

        public virtual List<Course> Courses { get; set; }

    }
}
