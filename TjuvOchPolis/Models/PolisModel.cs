using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis.Models
{
    class PolisModel : PersonModel
    {
        public List<InventoryModel> Beslagtaget = new List<InventoryModel>();
    }
}
