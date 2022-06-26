

using System.Collections.Generic;
using System.Linq;

namespace SOLIDPrinciples.DependencyInversionPrinciple.UserWithDIP
{
    class UserRepository : IUserRepository
    {
        private List<User> users = new()
        {
            new User { Id = 1, Username = "Sam", Password = "1234" },
            new User { Id = 2, Username = "John", Password = "4321" },
            new User { Id = 3, Username = "Tom", Password = "4567" },
        };

        public User GetUserByCredentials(string username, string password)
            => users.FirstOrDefault(user => user.Username == username && user.Password == password);


        public bool SaveUser(User user)
        {
            users.Add(user);
            return true;
        }
    }
}
