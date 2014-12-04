using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversityManagementSystemApp.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
         [Display(Name = "Teacher Name")]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
        [Display(Name = "Contact No")]
        public string Contact { get; set; }
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public int Credit { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }

        [NotMapped]
        public List<Course> Courses { get; set; }
    }
}