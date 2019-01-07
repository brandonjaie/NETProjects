using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRPGInventory.Items.Containers
{
    public class WetPaperSack : WeightConstrictedContainer
    {
        public WetPaperSack() : base(8, 3)
        {
            Name = "A wet paper sack";
            Description = "Damp and flimsy";
            Weight = 1;
            Type = ItemType.Container;
        }
    }
}
