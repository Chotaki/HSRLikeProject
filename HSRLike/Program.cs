using HSRLike;
using HSRLikeProject;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HSRLike;

namespace HSRLikeProject
{
    class Program
    {
        static void Main(string[] args)
        {

            // Test Gacha :
            Player player = new Player();
            Initialize init = new Initialize();
            init.createCharacters();
            init.createNPCs();
            Gacha.warp(init, player);

            string[] map = LoadMap();
                
            Console.CursorVisible = false;
            bool game = true;

            int UI = 1;

            Map.DisplayMap(player.PlayerTeam, map);

            while (game)
            {

                
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(0, 0);
                        break;

                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(0, 0);
                        break;
                        
                    case ConsoleKey.LeftArrow:
                        Console.SetCursorPosition(0, 0);
                        break;

            //playerCharacter[playerLocation.X, playerLocation.Y] = defaultTile;

                }
                Map.DisplayMap(player.PlayerTeam, map);

            // Set up our water tile
            Map waterTile = new Map();
            waterTile.character = '~';
            waterTile.colour = ConsoleColor.Blue;





            }
        }

        private static string[] LoadMap()
        {
            string[] content;
            using (StreamReader file = new StreamReader("../../../Map.txt"))
            {
               content = file.ReadToEnd().Split("\r\n");
            }
            return content;
        }
    }
}


