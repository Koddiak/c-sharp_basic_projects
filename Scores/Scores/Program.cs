using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your first name: ");
            string uName = Console.ReadLine();
            string date = DateTime.Today.ToShortDateString();

            Console.WriteLine($"\nWelcome back {uName}. Today is {date}.");

            string path = @"C:\GitHub\repositories\c-sharp_basic_projects\Scores\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);

            double tScore = 0.0;

            Console.WriteLine("\nStudent Scores: \n");
            foreach (string line in lines)
            {
                Console.WriteLine("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + " student scores. \tAverage score: " + avgScore);

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
