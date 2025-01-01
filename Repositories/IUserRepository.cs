using tourneyapp.Models;

namespace tourneyapp.Repositories
{
    public interface IUserRepository
    {
        public Task Create(User user, string confirmPassword);
        // Task<User> GetUserById(int id);
        // Task<User> CreateUser(User user);
        // Task<User> UpdateUser(User user);
        // Task<User> DeleteUser(User user);
    }
}