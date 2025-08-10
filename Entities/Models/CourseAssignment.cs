using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class CourseAssignment
    {
        public int Id { get; set; }
        public int UniversityCourseID { get; set; }
        public UniversityCourse UniversityCourse { get; set; } = null!;
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; } = null!;
    }
}
