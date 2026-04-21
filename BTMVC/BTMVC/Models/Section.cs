using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTMVC.Models
{
    public class Section
    {
        [Key]
        public int SectionId { get; set; }
        [Required]
        public string SectionName { get; set; } // VD: Lập trình Web - Sáng T5

        // Khóa ngoại tới Course
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course? Course { get; set; }

        // Khóa ngoại tới Teacher
        public int TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public Teacher? Teacher { get; set; }

        // 1 Lớp học phần có nhiều sinh viên đăng ký
        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
