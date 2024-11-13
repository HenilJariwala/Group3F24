using System.ComponentModel.DataAnnotations;

namespace Group3F24.TrackWise.Model
{
    public class LoginModel
    {
        [Required]
        public required string Username { get; set;}

        [Required]
        [MinLength(6)]
        public required string Password { get; set;}
    }
}
