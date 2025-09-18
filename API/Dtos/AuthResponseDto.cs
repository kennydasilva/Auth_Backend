namespace API.Dtos
{
    public class AuthResponseDto
    {
        public string? Token { get; set; }
        public Boolean? IsSuccess { get; set; }
        public string? Message { get; set; }
       
    }
}