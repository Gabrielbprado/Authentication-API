using System.ComponentModel.DataAnnotations;

namespace Authentication_API.Data.Dtos
{
    public class CreatedUserDto
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public DateTime DateBirth { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Required]
        [Compare("Password")]
        public string? PasswordCompare { get; set;}
    }
}
