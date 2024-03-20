using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SchoolProject1640.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Add any additional properties or methods here
        public string? FacultyId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}