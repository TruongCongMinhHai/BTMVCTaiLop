using System.ComponentModel.DataAnnotations;

namespace BTMVC.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required, StringLength(50)]
        public string StudentCode { get; set; } // Mã số sinh viên
        [Required, StringLength(100)]
        public string FullName { get; set; }

        // 1 Sinh viên có thể đăng ký nhiều lớp
        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
