using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [PrimaryKey(nameof(Code))]
    public class PromoCode
    {
        public string Code { get; set; } = null!;
        public decimal DiscountPercent { get; set; }
        public bool IsForUniversityStudentsOnly { get; set; }
        public ICollection<Student> Students { get; } = new List<Student>();
        public ICollection<OptionalCourse> OptionalCourses { get; } = new List<OptionalCourse>();
    }
}
