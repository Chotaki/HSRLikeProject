using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HSRLike;
using System.Runtime.Serialization.Formatters;

namespace HSRLikeProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player = new Player(0);
            Map map = new Map();
            Initialize init = new Initialize();
            init.CreateEnemy();
            init.createCharacters();
            init.createNPCs();
            init.createItems();
            init.createChests();
            Gacha.warp(init, player);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.CursorVisible = false;
            bool game = true;


            Map.DisplayMap(player.PlayerTeam, init.map);

            Console.SetCursorPosition(player.Position[0], player.Position[1]);
            Player.PlayerCharacter(player);
  


            while (!init.IsDisplayEnd)
            {
                //MAP
                Map.UpdateMap(player, init.map);
                Map.OtherCharacter(init);
                Player.PlayerCharacter(player);
                InputManager.Events(Console.ReadKey(true).Key, player, init);

                //BATTLE
                map.startFight(player,init);



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


