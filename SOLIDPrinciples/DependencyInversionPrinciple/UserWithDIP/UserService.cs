

namespace SOLIDPrinciples.DependencyInversionPrinciple.UserWithDIP
{
    class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public int Login(string username, string password)
            => _userRepository.GetUserByCredentials(username, password).Id;


        public bool Register(User user)
            => _userRepository.SaveUser(user);
    }
}
