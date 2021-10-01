using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    class SkapaPersonList
    {
        public static List<Tjuv> SkapaTjuvList(int num)
        {
            List<Tjuv> TjuvList = new List<Tjuv>();

            for (int i = 0; i < num; i++)
            {
                TjuvList.Add(new Tjuv());
                Thread.Sleep(200);
            }
            return TjuvList;
        }

        public static List<Medborgare> SkapaMedborgareList(int num)
        {
            List<Medborgare> MedborgareList = new List<Medborgare>();

            for (int i = 0; i < num; i++)
            {
                MedborgareList.Add(new Medborgare());
                Thread.Sleep(200);
            }
            return MedborgareList;
        }


    }
}
