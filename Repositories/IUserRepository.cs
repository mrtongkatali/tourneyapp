using tourneyapp.Models;

namespace tourneyapp.Repositories
{
    public interface IUserRepository
    {
        Task Create(User user, string confirmPassword);
        Task<User> Login(string email, string password);
        // Task<User> CreateUser(User user);
        // Task<User> UpdateUser(User user);
        // Task<User> DeleteUser(User user);
    }
}