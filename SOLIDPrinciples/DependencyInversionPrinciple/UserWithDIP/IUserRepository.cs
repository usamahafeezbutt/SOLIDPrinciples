
namespace SOLIDPrinciples.DependencyInversionPrinciple.UserWithDIP
{
    interface IUserRepository
    {
        public User GetUserByCredentials(string username, string password);
        public bool SaveUser(User user);
    }
}
