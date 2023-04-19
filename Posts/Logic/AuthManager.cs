using System;

namespace Logic
{
    public class AuthManager
    {
        public bool IsUserSignedIn { get => CurrentUser != null; }
        public string CurrentUserName { get => CurrentUser?.Username; }

        public DateTime LastSignIn { get; private set; }

        private PostsUser CurrentUser { get; set; }


        public AuthManager()
        {
        }

        public void SignIn(PostsUser user)
        {
            LastSignIn = DateTimeProvider.Now;
            CurrentUser = user;
        }

        public void SignOut()
        {
            CurrentUser = null;
        }
    }
}