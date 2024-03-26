using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HSRLikeProject
{
    class Program
    {
        static void Main(string[] args)
        {

            /*// Test Gacha :
            Player player = new Player();
            Initialize init = new Initialize();
            init.createCharacters();
            Gacha.warp(init, player);
            Console.WriteLine(player.PlayerTeam[0].Name);
            Console.WriteLine(player.PlayerTeam[1].Name);
            Console.WriteLine(player.PlayerTeam[2].Name);
            Console.WriteLine(player.PlayerTeam[3].Name);*/

            bool game = true;
           

            Map defaultTile = new Map();
            defaultTile.character = 'o';
            defaultTile.colour = ConsoleColor.Green;

            Map.FillMap(defaultTile);


            // Set up our water tile
            Map ground = new Map();
            ground.character = '^';
            ground.colour = ConsoleColor.Gray;

            // Create a little lake
            Map.CreateRectangle(new Point(3, 3), 24, 114, ground);

            Map playerCharacter = new Map();
            playerCharacter.colour = ConsoleColor.Red;
            playerCharacter.character = 'P';

            Map.CreateRectangle(new Point(15, 20), 1, 1, playerCharacter);

            Map.DisplayMap();

            while (game)
            {
                Console.CursorVisible = false;
                ConsoleKeyInfo input = Console.ReadKey(true);

                Map.DisplayMap();
                switch(input.Key) 
                {
                    case ConsoleKey.UpArrow:
                        break;
                }


            }
        }
    }
}


