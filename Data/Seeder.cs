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
                        Email = "test@test.com",
                        FirstName = "Test",
                        LastName = "User",
                        Password = "password",
                    },
                    new Models.User
                    {
                        Email = "test@test.com",
                        FirstName = "Test",
                        LastName = "User",
                        Password = "password",
                    }
                );

            context.SaveChanges();
        }
    }
}