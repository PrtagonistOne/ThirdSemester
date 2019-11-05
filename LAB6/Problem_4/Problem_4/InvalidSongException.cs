using System;

namespace Problem_4
{
    class InvalidSongException : Exception
    {
        public InvalidSongException(string messege)
           : base(messege)
        { }
    }
}
