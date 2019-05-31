using System;

namespace TaskAPI.Common
{
    public class DateTimeAdapter : IDateTime
    {
        public DateTime UtcNow
        {
            get { return DateTime.UtcNow; }
        }
    }
}
