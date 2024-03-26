using HSRLikeProject;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



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
                
            Console.CursorVisible = false;
            bool game = true;
            Map.DisplayMap();

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

                    case ConsoleKey.RightArrow:
                        Console.SetCursorPosition(0, 0);
                        break;

                }


                

                


            }
        }
    }
}


