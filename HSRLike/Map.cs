using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HSRLikeProject
{
    public class Map
    {

        public string[,] playerlocation = new string[241, 64];


        public static void DisplayMap()
        {

            
            StreamReader file = new("../../../Map.txt");

            int widthLeft = 50;

            string ln;
            
            Console.SetCursorPosition(widthLeft, 0);


            while ((ln = file.ReadLine()) != null)
            {
                for (int i = 0; i < 40; i++)
                {
                    ln = file.ReadLine();
                    Console.SetCursorPosition(widthLeft, i);

                    for (int j = 0; j < 120; j++) 
                    {
                        Console.Write(ln[j]);

                    }

                }
                

            }

            file.Close();
            Console.ReadLine();

        }

        public static void Move() 
        {

        }

    }
}

