using System;
using static System.Console;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World, learning C# to practice some OOP concepts not seen in JS");
            WriteLine("Strings have to be in double quotes.");

            if (args == null)
            {
                WriteLine("Anyways, what is your name?");
                string readName = ReadLine();
                WriteLine("Hello, {0}", readName);
                WriteLine(readName + "C# lets you concat strings using + signs.");
            }

            else if (args.Length > 0)
            {
                WriteLine("Received argument with {0}, cool!", args[0]);
            }

            CheckSleep();

            // -------------------- Helper Methods ---------------------
            void CheckSleep()
            {
                WriteLine("How many hours of sleep did you get last night?");
                int hoursOfSleep = int.Parse(ReadLine());

                if (hoursOfSleep > 8)
                {
                    WriteLine("Sounds like you are well rested.");
                }
                else
                {
                    WriteLine("Only {0}, you need to sleep a bit more.", hoursOfSleep);
                }
            }

        }
    }
}
