using System;

namespace TaskAPI.Common
{
    public interface IDateTime
    {
        DateTime UtcNow { get; }
    }
}
