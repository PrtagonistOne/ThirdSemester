using System;

namespace Problem_4
{
    class InvalidSongLengthException : Exception
    {
        public InvalidSongLengthException(string messege)
           : base(messege)
        { }
    }
}
