using System;

namespace Logic
{
    public class DateTimeProvider
    {
        private static DateTime? now;
        public static DateTime Now
        {
            get
            {
                if (now == null)
                {
                    return DateTime.Now;
                }
                else
                {
                    return (DateTime)now;
                }
            }
            set
            {
                now = value;
            }
        }

        public void Reset() => now = null;
    }
}