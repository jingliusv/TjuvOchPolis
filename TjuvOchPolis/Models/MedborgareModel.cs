using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    class MedborgareModel : PersonModel
    {
        public List<InventoryModel> Tillhorigheter = new List<InventoryModel>();

        public MedborgareModel()
        {
            Tillhorigheter.Add(new InventoryModel { ItemName = "Mobiltelefon" });
            Tillhorigheter.Add(new InventoryModel { ItemName = "Pengar" });
            Tillhorigheter.Add(new InventoryModel { ItemName = "Klocka" });
            Tillhorigheter.Add(new InventoryModel { ItemName = "Nyklar" });
        }
    }
}
