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
        public static void Events(ConsoleKey key, Player p, Initialize init)
        {
            if (p.InFight == false)
            {
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        Map.Move(0,-1, p, init); //move one tile up
                        break;
                    case ConsoleKey.DownArrow:
                        Map.Move(0, 1, p, init); //move one tile down
                        break;
                    case ConsoleKey.LeftArrow:
                        Map.Move(-1, 0, p, init); //move one tile left
                        break;
                    case ConsoleKey.RightArrow:
                        Map.Move(1, 0, p, init); //move one tile right
                        break;
                    case ConsoleKey.B:
                        UI.DisplayInventory();
                        switch(key)
                        {
                            case ConsoleKey.A:
                                p.Inventory[0].use(p);
                                break;
                            case ConsoleKey.Z:
                                p.Inventory[1].use(p);
                                break;
                            case ConsoleKey.E:
                                p.Inventory[2].use(p);
                                break;
                            case ConsoleKey.R:
                                p.Inventory[3].use(p);
                                break;
                            case ConsoleKey.T:
                                p.Inventory[4].use(p);
                                break;
                            case ConsoleKey.Y:
                                p.Inventory[5].use(p);
                                break;
                            case ConsoleKey.Escape:

                                Map.DisplayMap(p.PlayerTeam, init.map);
                                break;
                        }
                        break;
                    case ConsoleKey.T:
                        UI.DisplayTeam(p, 0);
                        switch (key)
                        {
                            case ConsoleKey.A:
                                UI.DisplayTeam(p, 0);
                                break;
                            case ConsoleKey.Z:
                                UI.DisplayTeam(p, 1);
                                break;
                            case ConsoleKey.E:
                                UI.DisplayTeam(p, 2);
                                break;
                            case ConsoleKey.R:
                                UI.DisplayTeam(p, 3);
                                break;
                        }
                        break;
                    case ConsoleKey.P:
                        break;
                    case ConsoleKey.F:
                        switch (Map.interactionRadar(p))
                        {
                            case <= 3: // NPCs (Cocolia boss included, condition in startDialog())
                                init.NPCList[Map.interactionRadar(p)].startDialog(init, init.NPCList[Map.interactionRadar(p)], p);
                                break;
                            case 4: // Chest
                                init.ChestList[p.DetectedChestId].open(p, p.DetectedChestId);
                                break;
                            case 5: //Mimic
                                p.fight(init, p, 1);
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
            else { 
            
                if (!p.WaitInput && p.WaitAction)

                {
                    switch (key)
                    {
                    case ConsoleKey.I:
                        p.CurrentAction = 0;
                        p.WaitAction = false;
                        break;
                    case ConsoleKey.O:
                        p.CurrentAction = 1;
                        p.WaitAction = false;
                        break;

                    case ConsoleKey.P:
                        p.CurrentAction = 2;
                        p.WaitAction = false;
                        break;
                    }
                } else if (p.WaitInput && !p.WaitAction)
                {
                    switch(key)
                    {
                        case ConsoleKey.A:
                            p.SelectedCharacter = 0;
                            p.WaitInput = false;
                            break;
                        case ConsoleKey.Z:
                            p.SelectedCharacter = 1;
                            p.WaitInput = false;
                            break;
                        case ConsoleKey.E:
                            p.SelectedCharacter = 2;
                            p.WaitInput = false;
                            break;
                        case ConsoleKey.R:
                            p.SelectedCharacter = 3;
                            p.WaitInput = false;
                            break;
                    }
                }

            }
        }
    }
}
