using SOLIDPrinciples.DependencyInversionPrinciple.UserWithDIP;
using SOLIDPrinciples.LiskovSubstitutePrinciple.EmployeeWithLSP;
using System;
using System.Collections.Generic;

namespace SOLIDPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { Id = 4, Username = "Eddie", Password = "1092" };
            IUserService userService = new UserService(new UserRepository());
            Console.WriteLine(userService.Register(user) ? "User Registered Successfully"
                : "Failed to register user");
            int userId = userService.Login(user.Username, user.Password);
            Console.WriteLine(userId > 0 ? "Login Successful" : "Login Failed");
        }
    }
}
