using System;

namespace Problem_5
{
    delegate void happens(string dateOfYear);
    class Events 
    {
        public event happens wantedYear;
        public void Counter(string dateOfYear)
        { wantedYear(dateOfYear); }


    }
}
