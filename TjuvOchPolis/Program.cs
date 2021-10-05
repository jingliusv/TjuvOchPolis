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
            StadModel stad = new StadModel();

            ConsoleUI.WelcomeInfo();
            int numThieves = "Hur många tjuvar vill du skapa: ".RequestIntAnswer();
            List<TjuvModel> TList = CreatePersonList.SkapaTjuvList(numThieves);
            
            int numCitizen = "Hur många medborgare vill du skapa: ".RequestIntAnswer();
            List<MedborgareModel> MList = CreatePersonList.SkapaMedborgareList(numCitizen);

            int numPolice = "Hur många polis vill du skapa: ".RequestIntAnswer();
            List<PolisModel> PList = CreatePersonList.SkapaPolisList(numPolice);
            Console.Clear();

            do
            {
                ConsoleUI.DrawCity(stad);

                foreach (var tjuv in TList)
                    MovePerson.MoveAndShowPerson("T", tjuv, stad);

                foreach (var medborgare in MList)
                    MovePerson.MoveAndShowPerson("M", medborgare, stad);

                foreach (var polis in PList)
                    MovePerson.MoveAndShowPerson("P", polis, stad);

                GameLogic.CheckTjuvMeborgareMeet(TList, MList);
                GameLogic.CheckTjuvPolisMeet(TList, PList);

                ConsoleUI.ShowResultMessage();

            } while (true);

        }
   
    }
}
