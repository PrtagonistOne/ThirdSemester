using System;

namespace Problem_5
{
    class Events 
    {
        public delegate void happens(string dateOfYear);
        public event happens wantedYear;
        public void Counter(string dateOfYear)
        { wantedYear(dateOfYear); }


    }
}
