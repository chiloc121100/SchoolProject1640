
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject1640.Models
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("UserFNoti")]
        public virtual ApplicationUser? ApplicationUser { get; set; }
        public string? UserID { get; set; }
        public string? Message { get; set; }
        [ForeignKey("FacultyFNoti")]
        public virtual Faculty? Faculty { get; set; }
        public string? FacultyId { get; set; }
        [ForeignKey("RoleFNoti")]
        public virtual ApplicationRole? Role { get; set; }
        public string? RoleId { get; set; }
        public string? SendBy { get; set; }
        public bool? isRead { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;

    }
}
