using System;

namespace Logic
{
    public struct Log
    {
        public Log(string username, Action action, DateTime date)
        {
            Username = username;
            Action = action;
            Date = date;
        }
        public string Username { get; private set; }
        public Action Action { get; private set; }
        public DateTime Date { get; private set; }
    }
}
