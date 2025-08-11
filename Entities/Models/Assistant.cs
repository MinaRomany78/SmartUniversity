using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Assistant
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; } = null!;
        public ApplicationUser ApplicationUser { get; set; } = null!;
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; } = null!;
        public ICollection<CourseAssistant> CourseAssistants { get; } = new List<CourseAssistant>();
        public ICollection<Feedback> Feedbacks { get; } = new List<Feedback>();
        public ICollection<Comment> Comments { get; } = new List<Comment>();
        public object Course { get; set; }
    }
}
