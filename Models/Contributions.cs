using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolProject1640.Models
{
    public class Contribution
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Faculty { get; set; }
        public string? AcademicYear { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ClosureDate { get; set; }
        public DateTime FinalClosureDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
