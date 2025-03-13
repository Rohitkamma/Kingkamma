using System;

namespace DungeonExplorer
{
    internal class Game
    {
        private Player player;
        private Room currentRoom;

        public Game()
        {
            // Initialize the game with one room and one player
            player = new Player("Hero", 100);
            currentRoom = new Room("You are in a dark cave. There is a faint light to the north.");
        }

        public void Start()
        {
            // Change the playing logic into true and populate the while loop
            bool playing = true;
            while (playing)
            {
                Console.WriteLine(currentRoom.GetDescription());
                Console.WriteLine("What would you like to do? (type 'exit' to quit)");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    playing = false;
                }
                else if (input.ToLower() == "pickup")
                {
                    player.PickUpItem("Mysterious Artifact");
                    Console.WriteLine("You picked up a Mysterious Artifact.");
                }
                else if (input.ToLower() == "status")
                {
                    player.DisplayStatus();
                }
                else
                {
                    Console.WriteLine("Invalid command. Try again.");
                }
            }
        }
    }
}