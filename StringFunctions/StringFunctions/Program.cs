using System;
using System.Text;

namespace StringFunctions
{
    class Program
    {
        static void Main()
        {
            //string name = "Jesse";
            //string quote = "The name said, \"Hello\", Jesse.\nHello on a new line.\n\tHello on a tab.";
            //string fileName = "C:\\Users\\Jesse";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
