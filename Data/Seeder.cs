namespace tourneyapp.Data
{
    public class Seeder
    {
        public static void SeedUsers(ApplicationContext context)
        {
            context.User
                .AddRange(
                    new Models.User
                    {
                        Email = "user1@demo.com",
                        FirstName = "One",
                        LastName = "User",
                        Password = "password",
                    },
                    new Models.User
                    {
                        Email = "user2@demo.com",
                        FirstName = "Two",
                        LastName = "User",
                        Password = "password",
                    }
                );

            context.SaveChanges();
        }
    }
}