using System.ComponentModel.DataAnnotations;

namespace SchoolProject1640.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? FileName { get; set; } // luu path name
        public string? FilePath { get; set; } // luu file path
        public int? ContributionId { get; set; } // Submission
        public string? AccountId { get; set; } // ten nguoi dung
        public int? State { get; set; } = 0;// 1 pending // 2 complete 3 4 ... 
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
    }
}
