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
            
            StreamReader file = new StreamReader("../../../Map.txt");

            Console.SetCursorPosition(50, 0);

            int witdhL = 575;
            string ln;
            int counter = 0;

            ln = file.ReadLine();

            while (ln != null)
            {
                for (int i = 0; i < 63; i++)
                {
                    ln = file.ReadLine();
                    Console.SetCursorPosition(50, i);

                    for (int j = 0; j < 101; j++) 
                    {
                        Console.Write(ln[j]);


                    }
                }


                
            }

            file.Close();
            
        }
        public static void Move() 
        {

        }

    }
}

