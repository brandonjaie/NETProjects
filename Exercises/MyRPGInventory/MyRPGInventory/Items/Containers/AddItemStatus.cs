using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRPGInventory.Items.Containers
{
    public enum AddItemStatus
    {
        Success,
        BagIsFull,
        ItemToHeavy,
        ItemNotRightType
    }
}
