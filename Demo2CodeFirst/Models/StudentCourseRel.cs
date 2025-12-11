using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2CodeFirst.Models
{
    internal class StudentCourseRel
    {
        [Key]
        [ForeignKey ("Student")]    
        public int StdId { get; set; }

        [Key]
        [ForeignKey("Course")]
        public int CrsId { get; set; }

        public int? Degree { get; set; }

        public Student Student { get; set; }

        public Course Course { get; set; }
    }
}
