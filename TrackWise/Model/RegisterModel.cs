using System.ComponentModel.DataAnnotations;

namespace Group3F24.TrackWise.Model
{
    public class RegisterModel
    {
        [Required]
        public required string Name { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [MinLength(8)]
        public required string Password { get; set; }

        [Required]
        [MinLength(8)]
        public required string ConfirmPassword { get; set; }
    }
}
