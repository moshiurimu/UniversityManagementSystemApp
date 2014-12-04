using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace UniversityManagementSystemApp.Models
{
    public class CourseAssign
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        [Display(Name = "Teacher")]
        public int TeacherId { get; set; }
        [Display(Name = "Course")]
        public int CourseId { get; set; }

        public int Credit { get; set; }
         [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
         [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { get; set; }
         [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }

    }
}