using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class OptionalCourse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool IsAvailableForUniversityStudents { get; set; }
        public string PromoCode { get; set; } = string.Empty;
        public PromoCode PromoCodeEntity { get; set; } = null!;
        public ICollection<OptionalCourseEnrollment> OptionalCourseEnrollments { get; } = new List<OptionalCourseEnrollment>();
    }
}
