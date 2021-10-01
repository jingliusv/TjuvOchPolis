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
            List<Tjuv> TList = SkapaPersonList.SkapaTjuvList(3); 
            List<Medborgare> MList = SkapaPersonList.SkapaMedborgareList(10);
            
            do
            {
                DrawCity();

                foreach (var tjuv in TList)
                    tjuv.MoveAndShowPerson("T");

                foreach (var medborgare in MList)
                    medborgare.MoveAndShowPerson("M");

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

        private static void DrawCity()
        {
            Console.Clear();
            Stan stan = new Stan();
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
