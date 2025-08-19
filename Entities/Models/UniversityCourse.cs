﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class UniversityCourse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int CreditHours { get; set; }
        public string Term { get; set; } = string.Empty;
        public ICollection<Enrollment> Enrollments { get; } = new List<Enrollment>();
        public ICollection<Material> Materials { get; } = new List<Material>();
        public ICollection<SubjectTask> Tasks { get; } = new List<SubjectTask>();
        public int? DoctorID { get; set; }
        public Doctor Doctor { get; set; } = null!;
        public ICollection<DoctorAssistant> DoctorAssistants { get; } = new List<DoctorAssistant>();
        public ICollection<AssistantCourse> AssistantCourses { get; } = new List<AssistantCourse>();
    }
}
