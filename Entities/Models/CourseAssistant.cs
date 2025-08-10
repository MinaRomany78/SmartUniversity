using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class CourseAssistant
    {
        public int Id { get; set; }
        public int UniversityCourseID { get; set; }
        public UniversityCourse UniversityCourse { get; set; } = null!;
        public int AssistantID { get; set; }
        public Assistant Assistant { get; set; } = null!;
    }
}
