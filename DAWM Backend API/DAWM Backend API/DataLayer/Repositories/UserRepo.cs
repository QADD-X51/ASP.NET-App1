using DAWM_Backend_API.DataLayer.Models;

namespace DAWM_Backend_API.DataLayer.Repositories
{
    public class UserRepo
    {
        public List<User> GetAll()
        {
            var returned = DbContext.Users;

            return returned;
        }

        public User GetById(int userId)
        {
            var returned = DbContext.Users
                .Where(q => q.Id == userId)
                .FirstOrDefault();

            return returned;
        }

        public User GetByIdWithCars(int userId)
        {
            var returned = DbContext.Users
               .Select(e => new User
               {
                   Username = e.Username,
                   Email = e.Email,
                   Id = e.Id,
                   Password = e.Password,
                   PhoneNumber = e.PhoneNumber,
                   Cars = e.Cars
                        .Select(g => g)
                        .OrderByDescending(g => g.Price)
                        .ToList()
               })
               .FirstOrDefault(e => e.Id == userId);

            return returned;
        }

        public bool AddUser(User user)
        {
            DbContext.Users.Add(user);
            return true;
        }

        public bool DeleteUserById(int userId)
        {
            return DbContext.Users.Remove(GetById(userId));
        }

        public bool EditUserById(int userId, User newUser)
        {
            if (newUser == null)
                return false;

            newUser.Id = userId;

            if (!DeleteUserById(userId))
                return false;
            if (!AddUser(newUser))
                return false;

            return true;
        }
    }
}
