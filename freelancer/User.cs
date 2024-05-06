using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancer
{
    public enum UserType
    {
        Freelancer,
        Client
    }
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }

        // constructor method
        public User(string username, string password, UserType userType)
        {
            Username = username;
            Password = password;
            UserType = userType;
        }
    }
}