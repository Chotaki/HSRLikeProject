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
            Player player = new Player(0);
            Initialize init = new Initialize();
            init.createCharacters();
            //init.createNPCs();
            Gacha.warp(init, player);

            string[] map = LoadMap();
                
            Console.CursorVisible = false;
            bool game = true;

            int UI = 1;

            Map.DisplayMap(player.PlayerTeam, map);

            Console.SetCursorPosition(player.Position[0], player.Position[1]);
            Player.PlayerCharacter(player);
  


            while (game)
            {

                Player.PlayerCharacter(player);
                Map.UpdateMap(player, map);  
                InputManager.Events(Console.ReadKey(true).Key, player);


            }
        
        }


        public static string[] LoadMap()
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


