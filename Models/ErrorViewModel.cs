using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace testNettly.web.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class User
    {
        public int UserId { get; set; }

        [Required] // Indicates that the property is required
        public string Username { get; set; }

        [Required] // Use this annotation to mark the field as required
        public string Password { get; set; }

        [Required]
        [EmailAddress] // Validates the property for email format
        public string Email { get; set; }
    }

    public class ProfileImageViewModel
    {
        public IFormFile ProfileImage { get; set; }
    }

    public class SettingsViewModel
    {
        public bool IsDarkModeEnabled { get; set; }
        public bool EmailNotificationsEnabled { get; set; }
        public IFormFile ProfileImage { get; set; }
    }


    public class ChangePasswordViewModel
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }

    public class Booking
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime Date { get; set; }
    }

    public class FeedbackViewModel
    {
        internal object Score;

        public int Id { get; set; }
        public string Username { get; set; }  // Example property
        public string Comment { get; set; }  // Example property
        public int Rating { get; set; }  // Example property


    }

    public class ApplicationUser : IdentityUser
    {
        // You can add additional properties here if needed
    }

}
