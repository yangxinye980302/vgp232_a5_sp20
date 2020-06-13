using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {

            static void Main(string[] args)
            {
                Console.WriteLine("Assignment 5");

                Character myCharacter = new Character("Bob", RaceCatagory.Elf, 100);

                myCharacter.TakeDamage(10);

                myCharacter.RestoreHealth(10);

                Console.WriteLine("The game has ended with {0} with {1} health", myCharacter.Name, myCharacter.HealthPoints);

                Inventory items = new Inventory(5);
                Item item1 = new Item("yang", 3, ItemType.consumable);
                Item item2 = new Item("xinye", 4, ItemType.equipment);
                Item item3 = new Item("leo", 5, ItemType.key);
                items.Add(item1);
                items.Add(item2);
                items.Add(item3);
           
                items.Remove(item1);
                items.ShowInventory();

            }

        }
    }
}
