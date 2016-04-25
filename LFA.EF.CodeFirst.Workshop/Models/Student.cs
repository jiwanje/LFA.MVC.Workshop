using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LFA.EF.CodeFirst.Workshop.Models
{
    
    public class Student
    {
        [Key]
        public int StudentKey { get; set; }
        [StringLength(500)]
        public string StudentName { get; set; }

        public StudentAddress StudentAddress { get; set; }

        public Standard Standards { get; set; }

    }

    public class StudentAddress
    {
        [Key, ForeignKey("Student")]
        public int StudentId { get; set; }
        public int Stage { get; set; }        
        public string City { get; set; }
        public Student Student { get; set; }
    }

    public class Standard
    {
        
        public int StandardId { get; set; }
        public string Name { get; set; }

        public int StudentId { get; set; }
        public IList<Student> Students { get; set; }
    }
}