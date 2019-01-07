using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MyRPGInventory.Items.Containers;
using MyRPGInventory.Items.Potions;
using MyRPGInventory.Items;
using MyRPGInventory.Items.Weapons;

namespace MyRPGInventory.Tests
{
    [TestFixture]
    public class ContainerTests
    {
        [Test]
        public void CanAddItemToBackpack()
        {
            Backpack b = new Backpack();
            HealthPotion p = new HealthPotion();

            AddItemStatus actual = b.AddItem(p);
            Assert.AreEqual(AddItemStatus.Success, actual);
        }

        [Test]
        public void CannotAddItemToFullBackpack()
        {
            Backpack b = new Backpack();
            GreatAxe axe = new GreatAxe();

            b.AddItem(axe);
            b.AddItem(axe);
            b.AddItem(axe);
            b.AddItem(axe);

            AddItemStatus actual = b.AddItem(axe);
            Assert.AreEqual(AddItemStatus.BagIsFull, actual);

        }

        [Test]
        public void CanRemoveItemFromBackpack()
        {
            Backpack b = new Backpack();
            HealthPotion p = new HealthPotion();

            b.AddItem(p);
            Item actual = b.RemoveItem();
            Assert.AreEqual(p, actual);
        }

        [Test]
        public void EmptyBagReturnsNull()
        {
            Backpack b = new Backpack();
            Item item = b.RemoveItem();

            Assert.IsNull(item);
        }

        [Test]
        public void PotionSatchelOnlyAllowsPotions()
        {
            PotionSatchel ps = new PotionSatchel();
            GreatAxe axe = new GreatAxe();
            HealthPotion p = new HealthPotion();
           
            AddItemStatus result = ps.AddItem(axe);
            Assert.AreEqual(AddItemStatus.ItemNotRightType, result);

            result = ps.AddItem(p);
            Assert.AreEqual(AddItemStatus.Success, result);
        }

        [Test]
        public void WeightRestrictedBagRestrictsWeight()
        {
            WetPaperSack wps = new WetPaperSack();
            HealthPotion potion = new HealthPotion();
            Sword sword = new Sword();

            Assert.AreEqual(AddItemStatus.Success, wps.AddItem(potion));

            Assert.AreEqual(AddItemStatus.ItemToHeavy, wps.AddItem(sword));

            Item item = wps.RemoveItem();

            Assert.AreEqual(AddItemStatus.Success, wps.AddItem(sword));
        }
    }
}
