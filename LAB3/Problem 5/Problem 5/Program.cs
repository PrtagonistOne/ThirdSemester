using System;

namespace Problem_5
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Input First Date: ");
            string data1 = Console.ReadLine();
            string[] date1 = data1.Split(' ');

            int n = date1.Length;

            int[] mod1 = new int[n];

            for (int i = 0; i < n; i++)
            {
                mod1[i] = Convert.ToInt32(date1[i]);
            }
            Console.WriteLine("Input Second Date: ");
            string data2 = Console.ReadLine();
            string[] date2 = data2.Split(' ');

            int n1 = date2.Length;

            int[] mod2 = new int[n1];
            int year = 0;
            int month = 0;
            int days = 0;
            for (int i = 0; i < n1; i++)
            {
                mod2[i] = Convert.ToInt32(date2[i]);
            }
    
       
                    year = mod2[0] - mod1[0];                
                    month = mod2[1] - mod1[1];                  
                    days = mod2[2] - mod1[2];            



            double highyear = year / 4;
            double years = year*365 + highyear;            
            double months = month* 30.4167;
            double Output = years + months + days;
            if (Output < 0)
            {              
                Output = Math.Ceiling(Output);
                Output *= -1;
            }
            Console.WriteLine($"Output is: {Math.Ceiling(Output)}");

        }
        
    }
}
