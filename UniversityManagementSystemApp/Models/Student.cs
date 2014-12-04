using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversityManagementSystemApp.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
         [Display(Name = "Student Name")]
        public string Name { get; set; }
        public string Email { get; set; }
        [Display(Name = "Contact No")]
        public string ContactNo { get; set; }
        public DateTime DateTime { get; set; }
        public string Address { get; set; }
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
         [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }  
    }
}