using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TjuvOchPolis.Models;

namespace TjuvOchPolis
{
    class GameLogic
    {
        public static int NumberOfRobbed = 0;
        public static int NumberOfThiefGetCaught = 0;
        public static void CheckTjuvMeborgareMeet(IEnumerable<TjuvModel> tjuv, IEnumerable<MedborgareModel> medborgare)
        {
            foreach (var m in medborgare)
            {
                foreach (var t in tjuv)
                {
                    if(m.X == t.X && m.Y == t.Y)
                    {
                        // take random things fron inventory of medborgare
                        if(m.Tillhorigheter.Count > 0)
                        {
                            StealRandomThing(m, t);
                            NumberOfRobbed++;
                            Program.ShowMessage("Tjuvar rånar medborgare.");
                            Thread.Sleep(2000);
                        }
                                              
                    }
                }
            }
        }

        public static void CheckTjuvPolisMeet(IEnumerable<TjuvModel> tjuv, IEnumerable<PolisModel> polis)
        {
            foreach (var p in polis)
            {
                foreach (var t in tjuv)
                {
                    if (p.X == t.X && p.Y == t.Y)
                    {
                        // take all things from tjuv to polis inventory
                        if (t.Stoldgods.Count > 0)
                        {
                            TakeStolenThing(p, t);
                            NumberOfThiefGetCaught++;
                            Program.ShowMessage("Polis tar tjuv.");
                            Thread.Sleep(2000);
                        }
    
                    }
                }
            }
        }

        private static void TakeStolenThing(PolisModel polis, TjuvModel tjuv)
        {
            foreach (var item in tjuv.Stoldgods)
            {
                polis.Beslagtaget.Add(item);
            }
            tjuv.Stoldgods.Clear();
        }


        private static void StealRandomThing(MedborgareModel medborgare, TjuvModel tjuv)
        {         
            Random rnd = new Random();
            int index = rnd.Next(0, medborgare.Tillhorigheter.Count - 1);
            string stolenGods = medborgare.Tillhorigheter[index].ItemName;
            medborgare.Tillhorigheter.RemoveAt(index);
            tjuv.Stoldgods.Add(new InventoryModel { ItemName = stolenGods });            
        }
    }
}
