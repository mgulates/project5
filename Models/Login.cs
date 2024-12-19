using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace project5.Models
{
    public class LogIn : IdentityUser
    {

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]

        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
        public bool RememberMe { get; set; }
    }
}