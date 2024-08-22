using System.ComponentModel.DataAnnotations;

namespace API.DTO
{
    public class UserDto
    {
        public required string Username { get; set; }
        public required string Token { get; set; }
    }
}
