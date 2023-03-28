using DAWM_Backend_API.DataLayer.Models;

namespace DAWM_Backend_API.DataLayer.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public List<CarDto> Cars { get; set; }
    }
}
