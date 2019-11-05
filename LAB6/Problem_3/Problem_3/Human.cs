using System;


namespace Problem_3
{
    abstract class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                bool Upper;
                Upper = Char.IsUpper(value[0]);

                if (!Upper)
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
                else if (value.Length <= 3)
                { 
                    throw new ArgumentException("Expected lenght at least 4 symbols! Argument: firstName"); 
                }
                else { firstName = value; }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                bool Upper;
                Upper = Char.IsUpper(value[0]);

                if (!Upper)
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName"); 
                }
                else if (value.Length <= 2)
                { 
                    throw new ArgumentException("Expected lenght at least 3 symbols! Argument: lastName"); 
                }
                else 
                {
                    lastName = value;
                }
            }
        }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual void Display()
        {
            Console.WriteLine($"\nFirst Name: {FirstName}\nLast Name: {LastName}");
        }
    }
}
