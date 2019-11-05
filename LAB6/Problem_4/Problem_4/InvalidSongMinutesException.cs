using System;

namespace Problem_4
{
    class InvalidSongMinutesException : Exception
    {
        public InvalidSongMinutesException(string messege)
          : base(messege)
        { }
    }
}
