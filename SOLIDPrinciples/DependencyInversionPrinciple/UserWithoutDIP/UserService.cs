
namespace SOLIDPrinciples.DependencyInversionPrinciple.UserWithoutDIP
{
    class UserService
    {
        public bool Register(User user) => new UserRespository().SaveUser(user);
        
        public int Login(string username, string password)
            => new UserRespository().GetUserByCredentials(username, password).Id;      
    }
}
