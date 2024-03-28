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
        public static void Events(ConsoleKey key, Player p)
        {
            if (p.InFight == false)
            {
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        Map.Move(0,-1,p); //move one tile up
                        break;
                    case ConsoleKey.DownArrow:
                        Map.Move(0,1, p); //move one tile down
                        break;
                    case ConsoleKey.LeftArrow:
                        Map.Move(-1,0, p); //move one tile left
                        break;
                    case ConsoleKey.RightArrow:
                        Map.Move(1,0, p); //move one tile right
                        break;
                    case ConsoleKey.B:
                        //UI.displayInventory();
                        break;
                    case ConsoleKey.T:
                        //UI.displayTeam();
                        break;
                    case ConsoleKey.F:
                        /*switch (Map.InteractionRadar)
                        {
                            case <= 3: // NPCs (Cocolia boss not included)
                                //init.NPCList[Map.InteractionRadar].startDialog(init, init.NPCList[Map.InteractionRadar], p);
                                break;
                            case 4: // Chest
                                Chest.open(p);
                                break;
                            case 5: //Mimic
                                p.fight(1);
                                break;
                        }*/
                        break;
                    default:
                        break;
                }
            }
            else { 
            
                /*if (!p.WaitInput)

                {
                    switch (key)
                    {
                    case ConsoleKey.I:
                        p.CurrentAction = 0;
                        break;
                    case ConsoleKey.O:
                        p.CurrentAction = 1;
                        break;

                    case ConsoleKey.P:
                        p.CurrentAction = 2;
                        break;
                    }
                } else
                {
                    switch(key)
                    {
                        case ConsoleKey.A:
                            p.SelectedCharacter = 0;
                            break;
                        case ConsoleKey.Z:
                            p.SelectedCharacter = 1;
                            break;
                        case ConsoleKey.E:
                            p.SelectedCharacter = 2;
                            break;
                        case ConsoleKey.R:
                            p.SelectedCharacter = 3;
                            break;
                    }
                }*/

            }
        }
    }
}
