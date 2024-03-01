﻿using BussinessObject.Model.ModelUser;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BussinessObject.Model.ModelCourse
{
    public class Course
    {
        [Key]
        [Required]
        public string courseId { get; set; }
        [Required]
        public string courseName { get; set; }
        [Required]
        public double price { get; set; }
        public double rating { get; set; }
        [Required]
        public string description { get; set; }
        public int studentNumber { get; set; }
        public string certificate { get; set; }
        [Required]
        public string createBy { get; set; }
        public DateTime dateUpdate { get; set; } = DateTime.Now;
        [Required]
        public string language { get; set; }
        [Required]
        public double bmiMin { get; set; }
        [Required]
        public double bmiMax { get; set; }
        [Required]
        public int typeId { get; set; }
        [JsonIgnore]
        public ICollection<Enrollment>? enrollments { get; set; }
        [JsonIgnore]
        public ICollection<Feedback>? feedbacks { get; set; }
        [JsonIgnore]
        public virtual CourseAdmin? courseAdmin { get; set; }
        [JsonIgnore]
        public ICollection<Course_CourseManager_Mapping>? courseManagerMappings { get; set; }
    }
}
