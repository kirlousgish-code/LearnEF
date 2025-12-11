using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2CodeFirst.Models
{
    internal class Student
    {
        [Key]
        public int stdId { get; set; }

        [Required]
        [StringLength(20)]
        public required string stdName { get; set; }

        public int? Age { get; set; }

        [ForeignKey("Department")]
        public int DeptNo { get; set; }
        // Navigation Property
        public  Department Department { get; set; }


        public virtual List<StudentCourseRel> StudentCourseRel{ get; set; }

        override public string ToString()
        {
            return $"ID: {stdId}, Name: {stdName}, Age: {Age}, DeptNo: {DeptNo}";
        }

    }

}
