using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSRLike
{
    internal class Map
    {
        public static MapTile[,] map = new MapTile[32, 128];

        public class MapTile
        {
            public char character { get; set; }

            public ConsoleColor colour { get; set; }
        }



    }
}
