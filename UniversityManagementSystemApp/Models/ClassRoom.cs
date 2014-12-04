using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversityManagementSystemApp.Models
{
    public class ClassRoom
    {
        [Key]
        [Display(Name = "Class Room")]
        public int ClassRoomId { get; set; }
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        [Display(Name = "Course")]
        public int CourseId { get; set; }
        [Display(Name = "Room No")]
        public string RoomNo { get; set; }
        public string Days { get; set; }
        [Display(Name = "Start Time")]
        public TimeSpan StartTime { get; set; }
        [Display(Name = "AM Or MP")]
        public string StartTimeAmOrPm { get; set; }
        [Display(Name = "End Time")]
        public TimeSpan EndTime { get; set; }
        [Display(Name = "AM Or MP")]
        public string EndTimeAmOrPm { get; set; }


        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }


    }
}