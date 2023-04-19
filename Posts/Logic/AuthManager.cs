using System;
using System.Collections.Generic;

namespace Logic
{
    public class AuthManager
    {
        private List<Log> logs;

        public bool IsUserSignedIn { get => CurrentUser != null; }
        public string CurrentUserName { get => CurrentUser?.Username; }

        public DateTime LastSignIn { get; private set; }

        private PostsUser CurrentUser { get; set; }
        public List<Log> Logs { get => logs; set => logs = value; }

        public AuthManager()
        {
            logs = new List<Log>();
        }

        public void SignIn(PostsUser user)
        {
            LastSignIn = DateTimeProvider.Now;
            CurrentUser = user;
            LogAction(Action.SIGN_IN);
        }

        public void SignOut()
        {
            LogAction(Action.SIGN_OUT);
            CurrentUser = null;
        }

        private void LogAction(Action action)
        {
            Logs.Add(new Log(CurrentUser.Username, action, DateTimeProvider.Now));
        }
    }
}