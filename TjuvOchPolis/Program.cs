using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TjuvOchPolis.Models;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    class Program
    {
        static void Main(string[] args)
        {
            StanModel stan = new StanModel();
            List<TjuvModel> TList = CreatePersonList.SkapaTjuvList(4); 
            List<MedborgareModel> MList = CreatePersonList.SkapaMedborgareList(12);
            List<PolisModel> PList = CreatePersonList.SkapaPolisList(5);

            do
            {
                DrawCity(stan);

                foreach (var tjuv in TList)
                    MovePerson.MoveAndShowPerson("T", tjuv, stan);

                foreach (var medborgare in MList)
                    MovePerson.MoveAndShowPerson("M", medborgare, stan);

                foreach (var polis in PList)
                    MovePerson.MoveAndShowPerson("P", polis, stan);

                GameLogic.CheckTjuvMeborgareMeet(TList, MList);
                GameLogic.CheckTjuvPolisMeet(TList, PList);

                ShowResultMessage();

            } while (true);

        }

        

        private static void ShowResultMessage()
        {
            int numRobbed = GameLogic.NumberOfRobbed;
            int numGetCaught = GameLogic.NumberOfThiefGetCaught;
            if(numRobbed > 0 || numGetCaught > 0)
            {
                Console.SetCursorPosition(0, 22);
                string message = $"Antal rånade medborgare: {numRobbed} Antal gripna tjuvar: {numGetCaught}";
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

        private static void DrawCity(StanModel stan)
        {
            Console.Clear();

            // Topp sida
            for (int i = 0; i < stan.Width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("-");
            }

            // Bottom sida
            for (int i = 0; i < stan.Width; i++)
            {
                Console.SetCursorPosition(i, stan.Height);
                Console.Write("-");
            }

            // Vänster sida
            for (int i = 0; i < stan.Height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("|");
            }

            // Höger sida
            for (int i = 0; i < stan.Height; i++)
            {
                Console.SetCursorPosition(stan.Width, i);
                Console.Write("|");
            }
            Console.WriteLine("\n\n");
        }
    }
}
