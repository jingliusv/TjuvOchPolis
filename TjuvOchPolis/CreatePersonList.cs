using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TjuvOchPolis.Models;

namespace TjuvOchPolis
{
    class CreatePersonList<T> where T : PersonModel, new()
    {
        public static List<T> SkapaPersonList(int num)
        {
            List<T> personList = new List<T>();

            for (int i = 0; i < num; i++)
            {
                personList.Add(new T());
                Thread.Sleep(200);
            }
            return personList;
        }


    }
}
