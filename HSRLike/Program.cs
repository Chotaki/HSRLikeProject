using HSRLike;
using HSRLikeProject;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {

            // Test Gacha :
            Player player = new Player(0);
            Initialize init = new Initialize();
            init.createCharacters();
            init.createNPCs();
            Gacha.warp(init, player);
            Console.WriteLine(player.PlayerTeam[0].Name);
            Console.WriteLine(player.PlayerTeam[1].Name);
            Console.WriteLine(player.PlayerTeam[2].Name);
            Console.WriteLine(player.PlayerTeam[3].Name);

            init.NPCList[1].startDialog(init, init.NPCList[3], player);

            /*bool game = true;
           

            Map defaultTile = new Map();
            defaultTile.character = 'o';
            defaultTile.colour = ConsoleColor.Green;


            Map.FillMap(defaultTile);

            Map playerCharacter = new Map();
            playerCharacter.colour = ConsoleColor.Red;
            playerCharacter.character = 'P';

            Point playerLocation = new Point(5,5);

            //playerCharacter[playerLocation.X, playerLocation.Y] = defaultTile;


            // Set up our water tile
            Map waterTile = new Map();
            waterTile.character = '~';
            waterTile.colour = ConsoleColor.Blue;

            // Create a little lake
            Map.CreateRectangle(new Point(10, 10), 10, 10, waterTile);

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


            }*/
        }
    }
}


