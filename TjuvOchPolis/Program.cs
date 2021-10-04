using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    class Program
    {
        static void Main(string[] args)
        {
            StanModel stan = new StanModel();
            List<TjuvModel> TList = CreatePersonList.SkapaTjuvList(4); 
            List<MedborgareModel> MList = CreatePersonList.SkapaMedborgareList(10);
            
            do
            {
                DrawCity(stan);

                foreach (var tjuv in TList)
                    MovePerson.MoveAndShowPerson("T", tjuv, stan);

                foreach (var medborgare in MList)
                    MovePerson.MoveAndShowPerson("M", medborgare, stan);

                GameLogic.CheckTjuvMeborgareMeet(TList, MList);

                ShowResultMessage();

            } while (true);

        }

        

        private static void ShowResultMessage()
        {
            int antalRanade = GameLogic.NumberOfRobbed;
            if(antalRanade > 0)
            {
                Console.SetCursorPosition(0, 22);
                string message = $"Antal rånade medborgare: {antalRanade}";
                for (int i = 0; i < message.Length; i++)
                    Console.Write("-");
                Console.WriteLine();
                Console.WriteLine(message);
                Thread.Sleep(2000);
            }
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
