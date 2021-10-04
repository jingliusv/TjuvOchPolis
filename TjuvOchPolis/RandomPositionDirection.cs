using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    class RandomPositionDirection
    {
        public static Direction GetRandomDirection()
        {
            Random rnd = new Random();
            Type type = typeof(Direction);
            Array values = type.GetEnumValues();
            int index = rnd.Next(0, Enum.GetNames(typeof(Direction)).Length);
            Direction value = (Direction)values.GetValue(index);
            return value;
        }

        public static int GenerateRandomX(StanModel stan)
        {
            Random rnd = new Random();
            return rnd.Next(0, stan.Width);
        }

        public static int GenerateRandomY(StanModel stan)
        {
            Random rnd = new Random();
            return rnd.Next(0, stan.Height);
        }
    }
}
