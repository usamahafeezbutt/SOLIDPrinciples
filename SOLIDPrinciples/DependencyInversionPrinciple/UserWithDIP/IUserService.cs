

namespace SOLIDPrinciples.DependencyInversionPrinciple.UserWithDIP
{
    interface IUserService
    {
        public bool Register(User user);
        public int Login(string username, string password);
    }
}
