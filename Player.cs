using System;

namespace DungeonExplorer
{
    internal class Player
    {
        private string name;
        private int health;
        private string inventoryItem;

        public Player(string name, int health)
        {
            this.name = name;
            this.health = health;
            this.inventoryItem = null;
        }

        public string Name
        {
            get { return name; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public string InventoryItem
        {
            get { return inventoryItem; }
        }

        public void PickUpItem(string item)
        {
            inventoryItem = item;
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"Player: {name}, Health: {health}, Inventory: {inventoryItem ?? "Empty"}");
        }
    }
}