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
            Console.CursorVisible = false;

            Map.DisplayMap();

            ConsoleKeyInfo input = Console.ReadKey(true);

            while (game)
            {

                Map.DisplayMap();
                switch(input.Key) 
                {
                    case ConsoleKey.UpArrow:
                        break;
                    case ConsoleKey.DownArrow:
                        break ;
                    case ConsoleKey.LeftArrow:
                        break ;
                    case ConsoleKey.RightArrow:
                        break ;

                }


            }
        }
    }
}


