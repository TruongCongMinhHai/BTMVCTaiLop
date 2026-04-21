using System.ComponentModel.DataAnnotations;
using static System.Collections.Specialized.BitVector32;

namespace BTMVC.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        [Required, StringLength(100)]
        public string FullName { get; set; }

        // 1 Giáo viên dạy nhiều Lớp học phần
        public ICollection<Section>? Sections { get; set; }
    }
}
