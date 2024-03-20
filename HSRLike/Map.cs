using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSRLike
{
    public class Map
    {

        static int height = 32;
        static int width = 128;

        public static Map[,] map = new Map[height, width];

        public char character { get; set; }

        public ConsoleColor colour { get; set; }


        public static void FillMap(Map tile)
        {
            //ligne
            for (int row = 0; row < height; row++)
            {
                //colonne
                for (int col = 0; col < width; col++)
                {
                    map[row, col] = tile;
                }
            }

        }
    }
}

