using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    class RandomPositionDirection
    {
        public static Random rnd = new Random();
        public static Direction GetRandomDirection()
        {           
            Type type = typeof(Direction);
            Array values = type.GetEnumValues();
            int index = rnd.Next(0, Enum.GetNames(typeof(Direction)).Length);
            Direction value = (Direction)values.GetValue(index);
            return value;
        }

        public static int GenerateRandomX(StadModel stad)
        {
            return rnd.Next(1, stad.Width);
        }

        public static int GenerateRandomY(StadModel stan)
        {
            return rnd.Next(1, stan.Height);
        }
    }
}
