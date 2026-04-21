using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTMVC.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }

        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student? Student { get; set; }

        public int SectionId { get; set; }
        [ForeignKey("SectionId")]
        public Section? Section { get; set; }

        public float? Grade { get; set; } // Điểm số có thể cập nhật sau
    }
}
