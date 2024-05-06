using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancer
{
    public class UserData
    {
        // list to store users
        private List<User> users;

        //constructor
        public UserData()
        {
            users = new List<User>();
        }

        //Register new user
        public bool registerUser(string username, string password, string passwordConfirmation, UserType userType)
        {
            if (username != "" && password != "" && passwordConfirmation != "" && password == passwordConfirmation)
            {
                //check for existing username
                if (users.Any(u => u.Username == username))
                {
                    return false;
                    //username already exists
                }
                else
                {
                    //add user to list
                    users.Add(new User(username, password, userType));
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public bool authenticateUser(string username, string password)
        {
            if (username != "" && password != "")
            {
                return users.Any(u => u.Username == username && u.Password == password);
            }
            else
            {
                return false;
            }
        }
    }
}