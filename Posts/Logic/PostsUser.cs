using System;

namespace Logic
{
    public class PostsUser
    {
        private string username;
        private string profilePic = "default.png";

        public string Username
        {
            get => username;
            set
            {
                if (value == null || value.Length == 0)
                {
                    throw new ArgumentException("Username cannot be empty");
                }
                if (value.Length <= 3)
                {
                    throw new ArgumentException("Username must be at least 4 characters long");
                }
                username = value;
            }
        }

        public string ProfilePic { get => profilePic; set => profilePic = value; }
    }
}