using System;
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
        public ICollection<CourseAssignment> CourseAssignments { get; } = new List<CourseAssignment>();
        public ICollection<CourseAssistant> CourseAssistants { get; } = new List<CourseAssistant>();

    }
}
