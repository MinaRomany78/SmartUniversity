using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class OptionalCourseEnrollment
    {
        public int Id { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; } = null!;
        public int OptionalCourseID { get; set; }
        public OptionalCourse OptionalCourse { get; set; } = null!;
        public DateTime PurchaseDate { get; set; }
        public string AppliedPromoCode { get; set; } = string.Empty;
        public PromoCode AppliedPromoCodeEntity { get; set; } = null!;
    }
}
