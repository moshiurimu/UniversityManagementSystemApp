using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversityManagementSystemApp.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Display(Name = "Course Code")]
        public string Code { get; set; }
        public int Credit { get; set; }
         [Display(Name = "Course Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Semester { get; set; }
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
        

    }
}