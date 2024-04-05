using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject1640.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("UsersFMess")]
        public virtual ApplicationUser? ApplicationUser { get; set; }
        public string? AccountID { get; set; }
        [ForeignKey("ArtFTMess")]
        public virtual Article? Article { get; set; }
        public int? ArtID { get; set; }
        public string? Mess { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
    }
}
