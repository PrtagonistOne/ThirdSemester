using System;

namespace Problem_4
{
    class InvalidSongSecondsException : Exception
    {
        public InvalidSongSecondsException(string messege)
                 : base(messege)
        { }
    }
}
