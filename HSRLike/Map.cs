using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HSRLikeProject
{
    public class Map
    {
        static int height = Console.WindowHeight ;
        static int width = Console.WindowWidth;
        static int borderW = 3;

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

        // Displays the map to the player
        public static void DisplayMap()
        {
            // Clear the console so we can redisplay the map
            Console.Clear();
            //ligne
            for (int row = 0; row < height; row++)
            {
                //colonne
                for (int col = 0; col < width; col++)
                {
 
                    //couleur
                    Console.ForegroundColor = map[row, col].colour;
                    //tile
                    Console.Write(map[row, col].character);

                }

                Console.WriteLine();
            }
        }

        // Create rectangle on the map with the maptile
        public static void CreateRectangle(Point startPoint, int width, int height, Map tile)
        {
            // Starting from the point we specified, create a rectangle of the given map tile
            for (int row = startPoint.X; row < startPoint.X + width; row++)
            {
                // For all columns
                for (int col = startPoint.Y; col < startPoint.Y + height; col++)
                {
                    // Make that position the same as the tile passed in
                    map[row, col] = tile;
                }
            }
        }

    }
}

