using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;


namespace HSRLikeProject
{
    public class Map
    {

        public string[,] playerlocation = new string[241, 64];

        

        public static void DisplayMap(Character[] playerTeam, string[] lines)
        {



            int iMin = 60;
            int iMax = iMin +40;

            int jMin = 50;
            int jMax = jMin + 130;


            int down = 0;

            bool mapFinished = false;
            

                for (int i = 20; i <= 60; i++)   
                    {

                    Console.SetCursorPosition(50, 0 + down);


                    for (int j = jMin; j < jMax; j++) 
                    {

                        Console.Write(lines[i][j]);

                    }
               
                    down++;
                  
                }



            Console.SetCursorPosition(200, 12);
            int nmTeam = 0;

            while (nmTeam != 4) { 
                for (int i = 0; i < 4; i++)
                    {
                        Console.SetCursorPosition(200, 12 + 3);
                        Console.WriteLine(playerTeam[i].Name);
                        Console.SetCursorPosition(202, 12+3);
                        Console.Write("Lvl : " + playerTeam[i].Lvl);
                        nmTeam++;
                    }
            }





        }
        public static void Move() 
        {

        }

    }
}

