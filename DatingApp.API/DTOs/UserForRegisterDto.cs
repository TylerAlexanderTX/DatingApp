using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTOs
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage="You must use a password longer than 1 character")]
        public string Password { get; set; }
    }
}