﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BussinessObject.Model.ModelSession
{
    public class Lesson
    {
        [Key] public string lessonId { get; set; }
        [Required] public string videoFile { get; set; }
        [Required] public string caption { get; set; } //Lesson Name
        [Required] public string cover { get; set; }
        [Required] public string sessionId { get; set; }
        [Required] public bool isActive { get; set; }
        public decimal viewProgress { get; set; }

        [JsonIgnore]
        public virtual Session? Session { get; set; }
    }
}
