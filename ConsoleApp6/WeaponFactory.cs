using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ItemFactory
{
    internal class Item
    {
        public string Weapon { get; set; }
        public string Shield { get; set; }
        public string Armor { get; set; }
        public int Damage { get; set; }
        public int RequiredStrength { get; set; }

        public Item(string weapon, int damage, int requiredstrength)
        {
            Weapon = weapon;
            Damage = damage;
            RequiredStrength = requiredstrength;
        }

        public void PrintStats()
        {
            Console.WriteLine($"Weapon: {Weapon}");
            Console.WriteLine($"Damage: {Damage}");
            Console.WriteLine($"Required Strength: {RequiredStrength}");
        }

        internal class ItemsFactory
        {
            public Item CreateItem(string name, int damage, int requiredstrength)
            {
                return new Item(name, damage, requiredstrength);
            }
        }

        internal class CreateItem
        {
            public static void Main(string[] args)
            {
                ItemsFactory itemFactory = new ItemsFactory();

                Item sword = itemFactory.CreateItem("Sword", 10, 5);
                Item axe = itemFactory.CreateItem("Axe", 12, 7);

                Console.ReadLine();
            }
        }
    }

}
