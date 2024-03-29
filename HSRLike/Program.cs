﻿using System;
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

            //player.fight(init, player, 2);

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
                //Map.DisplayMap(player.PlayerTeam, map);
                Map.UpdateMap(player,map);
                Map.OtherCharacter();
                Player.PlayerCharacter(player);
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


