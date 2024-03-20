using HSRLike;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Map defaultTile = new Map();
            defaultTile.character = 'o';
            defaultTile.colour = ConsoleColor.Green;

            Map.FillMap(defaultTile);

        }

    }
}


