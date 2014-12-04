using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversityManagementSystemApp.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
         [Display(Name = "Department Code")]
        public string Code { get; set; }
         [Display(Name = "Department Name")]
        public string Name { get; set; }

        [NotMapped]
        public List<Student> Students { get; set; }
        [NotMapped]
        public List<Course> Courses { get; set; }
        [NotMapped]
        public List<Teacher> Teachers { get; set; }

    }
}