using HSRLikeProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSRLike
{
    public class InputManager
    {
        public void Move(string direction)
        {
            switch (direction)
            {
                case "up":
                     Console.WriteLine("Moved up");
                    break;
                case "down":
                    Console.WriteLine("Moved down");
                    break;
                case "left":
                    Console.WriteLine("Moved left");
                    break;
                case "right":
                    Console.WriteLine("Moved right");
                    break;
            }
        }

        public void Interact(int interactionId, Player p) 
        {
            switch (interactionId) //different cases - 1 : NPC / 2 : Chest / 3 : Mimic / 4 : Boss (Condition to start fight)
            {
                case 1:
                    Console.WriteLine("Interact with NPC");
                    break;
                case 2:
                    Console.WriteLine("Interact with Chest");
                    break;
                case 3:
                    Console.WriteLine("Interact with Mimic");
                    break;
                case 4:
                    if (p.WinCount < 10)
                    {
                        Console.WriteLine("...");      
                    }
                    else
                    {
                        Console.WriteLine("Interact with Boss - Fight Enhanced");
                    }
                    break;
            }
        }
    }
}
