using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    class GameLogic
    {
        public static int NumberOfRobbed;
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
                        }
                        NumberOfRobbed++;
                        //Console.WriteLine("En medborgare har blivit rånade");
                        Thread.Sleep(2000);
                    }
                }
            }
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
