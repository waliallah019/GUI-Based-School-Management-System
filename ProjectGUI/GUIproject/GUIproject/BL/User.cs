using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUIproject.DL;

namespace GUIproject.BL
{
    class User
    {
        private string role;
        private string username;
        private string password;

        //Getters
        
        public string getRole()
        {
            return this.role;
        }
        public string getUsername()
        {
            return this.username;
        }
        public string getPassword()
        {
            return this.password;
        }

        //Setters
        
        public bool setRole(string role)
        {
            this.role = role;
            return true;
        }
        public bool setUsername(string username)
        {
            this.username = username;
            return true;
        }
        public bool setPassword(string password)
        {
            this.password = password;
            return true;
        }

        //Constructors
        public User(string role)
        {
            this.role = role;
        }
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public User (string username, string password , string role) : this(role)
        {
            this.username = username;
            this.password = password;
        }

        //Behaviours
        public static User Authentication(string username, string password)
        {
            User builtIn = new User("Admin");
            foreach (User user1 in UserDL.users)
            {
                if (user1.getUsername() == username && user1.getPassword() == password)
                {
                    return user1;
                }
            }
            if (username == "asif" && password == "1111")
            {
                return builtIn;
            }
            return null;
        }

    }

}
