using System.ComponentModel.DataAnnotations;

namespace OnionArchitecture.Application.DTOs.Account
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
