using Microsoft.EntityFrameworkCore;
using tourneyapp.Data;
using tourneyapp.Helpers;
using tourneyapp.Models;

namespace tourneyapp.Repositories
{
   public class UserRepository : IUserRepository 
   {
        private readonly ApplicationDbContext _appDbContext;

        public UserRepository(ApplicationDbContext context)
        {
            _appDbContext = context;
        }

        public async Task Create(User user, string confirmPassword)
        {
            var existingUser = await _appDbContext.User.FirstOrDefaultAsync(u => u.Email == user.Email);
            if (existingUser != null)
            {
                throw new Exception("User with this email already exists.");
            }

            if (user.Password != confirmPassword)
            {
                throw new Exception("Password and Confirm Password do not match.");
            }

            user.Password = PasswordHelper.HashPassword(user.Password);

            await _appDbContext.User.AddAsync(user);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<User> Login(string email, string password)
        {
            var user = await _appDbContext.User.FirstOrDefaultAsync(u => u.Email == email);

            if (user == null || !PasswordHelper.VerifyPassword(password, user.Password))
            {
                throw new Exception("Invalid email address or Password");
            }

            return user;
        }
   } 
}