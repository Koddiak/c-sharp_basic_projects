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
                int age = 0;
                Console.WriteLine("What is your age?");
                bool validAnswer = int.TryParse(Console.ReadLine(), out age);

                Console.Write(Environment.NewLine);

                if (!validAnswer)
                {
                    Console.WriteLine("Please enter an integer representation of your age in years.");
                }
                else if (age <= 0)
                {
                    Console.WriteLine("Please enter a valid age in years.");
                }
                else if (age == 1)
                {
                    Console.WriteLine("You are {0} year old.", age);
                }
                else
                {
                    Console.WriteLine("You are {0} years old.", age);
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
