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
            Initialize init = new Initialize();
            init.CreateEnemy();
            init.createCharacters();
            init.createNPCs();
            init.createItems();
            init.createChests();
            Gacha.warp(init, player);
            /*Console.WriteLine(player.PlayerTeam[0].Name);
            Console.WriteLine(player.PlayerTeam[1].Name);
            Console.WriteLine(player.PlayerTeam[2].Name);
            Console.WriteLine(player.PlayerTeam[3].Name);

            for (int i = 0; i < 9; i++)
            {
                player.WinFight = true;
                player.PlayerTeam[0].levelUp(player);
            }
            Console.WriteLine(player.PlayerTeam[0].Lvl);*/

            /*Console.WriteLine(player.PlayerTeam[0].ATK);
            Console.WriteLine(player.PlayerTeam[1].ATK);
            Console.WriteLine(player.PlayerTeam[2].ATK);
            Console.WriteLine(player.PlayerTeam[3].ATK);*/

            string[] map = LoadMap();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.CursorVisible = false;
            bool game = true;

            int UI = 1;

            Map.DisplayMap(player.PlayerTeam, map);

            Console.SetCursorPosition(player.Position[0], player.Position[1]);
            Player.PlayerCharacter(player);
  


            while (game)
            {
                //MAP
                Map.UpdateMap(player, map);
                Map.OtherCharacter(init);
                Player.PlayerCharacter(player);
                InputManager.Events(Console.ReadKey(true).Key, player, init);

                //BATTLE
                //UI.DisplayFight(player);

                //TEAM
                //UI.DisplayTeam(player,0);

                //INVENTAIRE
                //UI.DisplayInventory(player);

                //PAUSE
                //UI.DisplayPause();



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


