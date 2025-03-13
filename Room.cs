using System;

namespace DungeonExplorer
{
    internal class Room
    {
        private string description;

        public Room(string description)
        {
            this.description = description;
        }

        public string GetDescription()
        {
            return description;
        }
    }
}