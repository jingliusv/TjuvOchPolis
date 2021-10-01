using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    class Medborgare : Person
    {
        public List<Inventory> Tillhorigheter = new List<Inventory>();

        public Medborgare()
        {
            Tillhorigheter.Add(new Inventory { ItemName = "Mobiltelefon" });
            Tillhorigheter.Add(new Inventory { ItemName = "Pengar" });
            Tillhorigheter.Add(new Inventory { ItemName = "Klocka" });
            Tillhorigheter.Add(new Inventory { ItemName = "Nyklar" });
        }
    }
}
