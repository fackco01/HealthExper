﻿using BussinessObject.Model.ModelCourse;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BussinessObject.Model.ModelSession
{
    public class Session
    {
        [Key]
        public string sessionId { get; set; }
        [Required] public string sessionName { get; set; }
        [Required] public DateTime dateStart { get; set; }
        [Required] public DateTime dateEnd { get; set; }
        public string? description { get; set; }
        [Required] public bool learnProgress { get; set; } // isActive
        public string? scoreResult { get; set; }
        [Required]
        public string courseId { get; set; }

        [JsonIgnore]
        public virtual Course? course { get; set; }
        [JsonIgnore]
        public virtual ICollection<Lesson>? Lessons { get; set;}
    }
}
