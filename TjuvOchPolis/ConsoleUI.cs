using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    static class ConsoleUI
    {
        public static void WelcomeInfo()
        {
            string msg = "Välkommen till Tjuv Och Polis Spel!";
            PrintLine(msg.Length);
            Console.WriteLine(msg);
            PrintLine(msg.Length);
            Console.WriteLine();
        }

        public static int RequestIntAnswer(this string message)
        {
            int output = 0;
            bool isValid = false;

            while (isValid == false)
            {
                Console.Write(message);
                isValid = int.TryParse(Console.ReadLine(), out output);
               
            }
            return output;
        }


        public static void ShowStatusMessage(string message)
        {
            Console.SetCursorPosition(5, 27);
            Console.WriteLine(message);
        }

        public static void ShowResultMessage()
        {
            int numRobbed = GameLogic.NumberOfRobbed;
            int numGetCaught = GameLogic.NumberOfThiefGetCaught;
            if (numRobbed > 0 || numGetCaught > 0)
            {
                Console.SetCursorPosition(0, 27);
                string message = $"Antal rånade medborgare: {numRobbed} | Antal gripna tjuvar: {numGetCaught}";
                PrintLine(message.Length);
                Console.WriteLine(message);
                Thread.Sleep(2000);
            }

        }

        private static void PrintLine(int lineLength)
        {
            for (int i = 0; i < lineLength; i++)
                Console.Write("-");
            Console.WriteLine();
        }

        public static void DrawCity(StadModel stan)
        {
            Console.Clear();

            // Topp sida
            for (int i = 1; i < stan.Width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("-");
            }

            // Bottom sida
            for (int i = 1; i < stan.Width; i++)
            {
                Console.SetCursorPosition(i, stan.Height);
                Console.Write("-");
            }

            // Vänster sida
            for (int i = 1; i < stan.Height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("|");
            }

            // Höger sida
            for (int i = 1; i < stan.Height; i++)
            {
                Console.SetCursorPosition(stan.Width, i);
                Console.Write("|");
            }
            Console.WriteLine("\n\n");
        }
    }
}
