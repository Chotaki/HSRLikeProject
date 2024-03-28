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
            Gacha.warp(init, player);

            string[] map = LoadMap();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.CursorVisible = false;
            bool game = true;


            Map.DisplayMap(player.PlayerTeam, map);

            Console.SetCursorPosition(player.Position[0], player.Position[1]);
            Player.PlayerCharacter(player);



            while (game)
            {
                //MAP
                Map.UpdateMap(player, map);
                Map.OtherCharacter();
                Player.PlayerCharacter(player);
                InputManager.Events(Console.ReadKey(true).Key, player);

                //BATTLE
                //UI.DisplayFight(player);

                //TEAM
                //UI.DisplayTeam(player,0);


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


