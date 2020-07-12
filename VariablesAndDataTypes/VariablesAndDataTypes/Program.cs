using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main()
        {
            // This is a simple program.
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false; //  this can have a true or a false value
            byte hoursWorked = 42; // represents an integer between 0 and 255
            sbyte currentTemperature = -23; // represents an integer between -128 and 127
            char questionMark = '\u2103'; // represents one Unicode character
            decimal moneyInBank = 100.5m; // represents any number up to 28 or 29 digits in length
            double heightInCentimeter = 211.30202092; // represents any number up to 15 or 16 digits in length
            float secondsLeft = 2.62f; // represents any number up to 7 digits in length
            int currentPinBallScore = 31324; // represents a whole number between roughly -2,000,000,000 and 2,000,000,000
            uint pixelWidth = 1280; // represents a whole number between 0 and about 4,000,000,000
            long moleculeDifference = -4843349238903; // represents a whole number between roughly negative 9 quintillion and positive 9 quintillion
            ulong airMoleculeInJar = 24328493492309; // represents a whole number between 0 and 18 quintillion
            short temperatureOnMars = -341; // represents a whole number between -32,678 and 32,767
            ushort antarcticaPopulation = 302; // represents a whole number between 0 and 65,535.
            string myName = "Koddiak"; // represents a set of 0 or more Unicode characters. Strings are delimited by double-quotation marks.

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);

            Console.WriteLine(rainingStatus);
            Console.ReadLine();
        }
    }
}
