using DAWM_Backend_API.DataLayer.Repositories;
using DAWM_Backend_API.DataLayer.Models;
using DAWM_Backend_API.DataLayer.Dtos;
using DAWM_Backend_API.DataLayer.Mapping;

namespace DAWM_Backend_API.Core.Services
{
    public class UserService
    {
        private UserRepo _userRepo { get; set; }

        public UserService(UserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public List<User> GetAll()
        {
            var returned = _userRepo.GetAll();

            return returned;
        }

        public UserDto GetById(int userId)
        {
            var user = _userRepo.GetById(userId);

            var result = user.ToUserDto();

            return result;
        }

        public bool AddUser(User user)
        {
            return _userRepo.AddUser(user);
        }

        public bool DeleteUser(int userId)
        {
            return _userRepo.DeleteUserById(userId);
        }

        public bool EditUser(int userId, User newUser)
        {
            return _userRepo.EditUserById(userId, newUser);
        }
    }
}
