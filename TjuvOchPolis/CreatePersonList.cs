using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    class CreatePersonList
    {
        public static List<TjuvModel> SkapaTjuvList(int num)
        {
            List<TjuvModel> TjuvList = new List<TjuvModel>();

            for (int i = 0; i < num; i++)
            {
                TjuvList.Add(new TjuvModel());
                Thread.Sleep(200);
            }
            return TjuvList;
        }

        public static List<MedborgareModel> SkapaMedborgareList(int num)
        {
            List<MedborgareModel> MedborgareList = new List<MedborgareModel>();

            for (int i = 0; i < num; i++)
            {
                MedborgareList.Add(new MedborgareModel());
                Thread.Sleep(200);
            }
            return MedborgareList;
        }

       


    }
}
