using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; } = null!;
        public ApplicationUser ApplicationUser { get; set; } = null!;
        //public ICollection<CourseAssignment> CourseAssignments { get; } = new List<CourseAssignment>();
        public ICollection<SubjectTask> Tasks { get; } = new List<SubjectTask>();
        //public ICollection<Assistant> Assistants { get; } = new List<Assistant>();
        public ICollection<UniversityCourse> UniversityCourses { get; } = new List<UniversityCourse>();

    }
}
