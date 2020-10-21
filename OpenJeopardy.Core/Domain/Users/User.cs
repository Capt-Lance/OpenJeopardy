using System;

namespace OpenJeopardy.Core.Users
{
    public class User
    {
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        private User()
        {
        }

        public Guid Id { get; private set; }

        public string Password { get; private set; }
        public string Username { get; private set; }
    }
}