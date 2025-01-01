using Microsoft.EntityFrameworkCore;
using tourneyapp.Data;
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
            if (user.Password != confirmPassword)
            {
                throw new Exception("Password and Confirm Password do not match.");
            }

            await _appDbContext.User.AddAsync(user);
            await _appDbContext.SaveChangesAsync();
        }
   } 
}