using System;

namespace Problem_4
{
    class InvalidSongNameException : Exception
    {
        public InvalidSongNameException(string messege)
                 : base(messege)
        { }
    }
}
