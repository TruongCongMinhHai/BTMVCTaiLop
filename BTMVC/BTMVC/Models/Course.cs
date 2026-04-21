using System.ComponentModel.DataAnnotations;
using static System.Collections.Specialized.BitVector32;

namespace BTMVC.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required, StringLength(100)]
        public string CourseName { get; set; }

        // 1 Khóa học có nhiều Lớp học phần
        public ICollection<Section>? Sections { get; set; }
    }
}
