using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_page_234
{
    class Program
    {
        static void Main()
        {
            try
            {
                int year = 0;
                Console.WriteLine("What year were you born?");
                bool validAnswer = int.TryParse(Console.ReadLine(), out year);

                Console.Write(Environment.NewLine);

                if (!validAnswer)
                {
                    Console.WriteLine("Please enter an integer representation of the year you were born.");
                }
                else if (year < 1903) //The oldest living person was born in 1903.
                {
                    Console.WriteLine("Please enter a valid year.");
                }
                else
                {
                    Console.WriteLine("You were born in the year {0}", year);
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! " + ex.Message);
            }
        }
    }
}
