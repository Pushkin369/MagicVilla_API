﻿namespace WebApi.Logging
{
    public class Logging : ILogging
    {
        public void Log(string message, string type)
        {
            if (type == "error")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR - " + message);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (type == "warning")
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("WARNING - " + message);
                Console.BackgroundColor = ConsoleColor.Black;
            } 
            else 
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("OK - " + message);
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}
