using System;
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

        
        [Required]
        public string Gender { get; set; }
        
        [Required]
        public string KnownAs { get; set; }
        
        [Required]
        public DateTime DateOfBirth { get; set; }
        
        [Required]
        public string City { get; set; }
        
        [Required]
        public string Country { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }

        public UserForRegisterDto(){
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }
    }
}