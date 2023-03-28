using DAWM_Backend_API.DataLayer.Models;
using DAWM_Backend_API.DataLayer.Dtos;

namespace DAWM_Backend_API.DataLayer.Mapping
{
    public static class UserMappingExtentions
    {
        public static UserDto ToUserDto(this User user)
        {
            if (user == null)
                return null;

            var returned = new UserDto();
            returned.Id = user.Id;
            returned.Username = user.Username;
            returned.Password = user.Password;
            returned.Email = user.Email;
            returned.Cars = user.Cars.ToCarDtoList();

            return returned;
        }
    }
}
