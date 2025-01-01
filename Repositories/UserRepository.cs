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
            throw new NotImplementedException();
        }
   } 
}