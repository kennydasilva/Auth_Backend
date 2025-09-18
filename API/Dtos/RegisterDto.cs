using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class RegisterDto
    {

         [Required]
        public string? FullName { get; set; } =String.Empty;
        public List<string> Roles { get; set; } 

        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        public string? Password { get; set; } =String.Empty;
    }
}