using System;


namespace Problem_4
{
    class InvalidArtistNameException : Exception
    {
        public InvalidArtistNameException(string messege)
            : base (messege)
        { }
    }
}
