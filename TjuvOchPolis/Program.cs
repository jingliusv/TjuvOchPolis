using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tjuv> TList = new List<Tjuv>();
            TList = SkapaPersonList.SkapaTjuvList(3);

            do
            {
                RitaStan();
                foreach (var tjuv in TList)
                {               
                    tjuv.DrawPerson("T");
                    tjuv.CheckPosition();
                    tjuv.IMove();                   
                }
            } while (true);


            Console.ReadLine();
        }

        private static void RitaStan()
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
