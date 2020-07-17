using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Pick a number: ");
                int numberOne = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Pick a second number: ");
                int numberTwo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dividing the first number by the second number...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            }
            catch (FormatException ex)
            {
                Console.Write(Environment.NewLine);
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.Write(Environment.NewLine);
                Console.WriteLine("Error! Cannot divide by zero.");
                return;
            }
            catch (Exception ex)
            {
                Console.Write(Environment.NewLine);
                Console.WriteLine("Error! " + ex.Message);
                return;
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
