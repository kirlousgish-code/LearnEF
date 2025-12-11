using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2CodeFirst.Models
{
    internal class Course
    {
        [Key]
        public int crsId { get; set; }

        [Required]
        [StringLength(20)]
        public string crsName { get; set; }

        public int crsDuration { get; set; }


        public virtual List<Department> Departments { get; set; }

        public virtual List<StudentCourseRel> StudentCourseRel { get; set; }

    }
}
