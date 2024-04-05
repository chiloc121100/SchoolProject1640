﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject1640.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string? Description { get; set; }
        public string? FileName { get; set; } // luu path name
        public string? FilePath { get; set; } // luu file path
        public int? ContributionId { get; set; } // Submission
        [ForeignKey("ContriFArt")]
        public virtual Contribution? Contribution { get; set; }
        public string? AccountId { get; set; } // ten nguoi dung
        [ForeignKey("UserFArt")]
        public virtual ApplicationUser? ApplicationUser { get; set; }
        public int? State { get; set; } = 0;// 1 pending // 2 complete 3 4 ... 
        public string? Image { get; set; }
        public bool? isPublicForGuest { get; set; } = false;// ten nguoi dung
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
    }
}
