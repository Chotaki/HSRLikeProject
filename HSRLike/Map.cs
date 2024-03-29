using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
using HSRLike;

namespace HSRLikeProject
{
    public class Map
    {

        private bool[] _fights = new[] {false, false,  false, false, false, false, false, false}; 

        public bool[] Fights { get => _fights; set => _fights = value; }

        public static void DisplayMap(Character[] playerTeam, string[] lines)
        {


            Console.SetCursorPosition(10 , 10);
            Console.Write("Pause (p)");
            Console.SetCursorPosition(10, 15);
            Console.Write("Inventaire (b)");
            Console.SetCursorPosition(10, 20);
            Console.Write("Team (t)");



            int iMin = 5;
            int iMax = iMin + 40;

            int jMin = 50;
            int jMax = jMin + 130;


            int down = 0;

            

                for (int i = iMin; i <= iMax; i++)   
                    {

                    Console.SetCursorPosition(50, 0 + down);


                    for (int j = jMin; j < jMax; j++) 
                    {

                        Console.Write(lines[i][j]);

                    }
               
                    down++;
                  
                }



            Console.SetCursorPosition(197, 12);
            int nmTeam = 0;
            int espacement = 3;
            while (nmTeam != 4) { 
                for (int i = 0; i < 4; i++)
                    {
                        Console.SetCursorPosition(197, 8 + espacement);
                        Console.WriteLine(playerTeam[i].Name);
                        Console.SetCursorPosition(190, 8 + espacement);
                        Console.Write("Lvl:" + playerTeam[i].Lvl);
                        nmTeam++;
                        espacement += 3;
                    }
            }


        }

        public static void OtherCharacter(Initialize init)
        {

            //NPC
            //Cocolia
            Console.SetCursorPosition (66, 5);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("C");
            Console.ForegroundColor = ConsoleColor.Gray;

            //Sampo
            Console.SetCursorPosition(115, 3);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("S");
            Console.ForegroundColor = ConsoleColor.Gray;

            //Welt
            Console.SetCursorPosition(160, 35);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("W");
            Console.ForegroundColor = ConsoleColor.Gray;

            //coffre
            foreach(Chest coffre in init.ChestList)
            {
                if (!coffre.IsOpen)
                {
                    Console.SetCursorPosition(coffre.Position[0], coffre.Position[1]);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("#");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }

            //Mimic

            Console.SetCursorPosition(155, 30);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("#");
            Console.ForegroundColor = ConsoleColor.DarkGray;      


        }

        public static void UpdateMap(Player p, string[] uptdateCharacter)
        {
            p.Position[0] += 1;
            Console.SetCursorPosition(p.Position[0], p.Position[1]);
            Console.Write(uptdateCharacter[p.Position[1] + 5 ][p.Position[0] ]);
            p.Position[1] += 1;
            Console.SetCursorPosition(p.Position[0], p.Position[1]);
            Console.Write(uptdateCharacter[p.Position[1] + 5][p.Position[0] ]);
            p.Position[0] -= 1;
            Console.SetCursorPosition(p.Position[0], p.Position[1]);
            Console.Write(uptdateCharacter[p.Position[1] + 5][p.Position[0]]);
            p.Position[0] -= 1;
            Console.SetCursorPosition(p.Position[0], p.Position[1]);    
            Console.Write(uptdateCharacter[p.Position[1] + 5][p.Position[0]]);
            p.Position[1] -= 1;
            Console.SetCursorPosition(p.Position[0], p.Position[1]);
            Console.Write(uptdateCharacter[p.Position[1] + 5][p.Position[0]]);
            p.Position[1] -= 1;
            Console.SetCursorPosition(p.Position[0], p.Position[1]);
            Console.Write(uptdateCharacter[p.Position[1] + 5][p.Position[0]]);
            p.Position[0] += 1;
            Console.SetCursorPosition(p.Position[0], p.Position[1]);
            Console.Write(uptdateCharacter[p.Position[1] + 5][p.Position[0]]);
            p.Position[0] += 1;
            Console.SetCursorPosition(p.Position[0], p.Position[1]);
            Console.Write(uptdateCharacter[p.Position[1] + 5][p.Position[0]]); 
            p.Position[0] -= 1;
            p.Position[1] += 1;
        }

        public static void Move(int moveSide, int moveUpDown, Player p, Initialize init) 
        {
            if (p.Position[0] == 66 && p.Position[1] == 6 && moveUpDown == -1 || p.Position[0] == 66 && p.Position[1] == 4 && moveUpDown == 1 || p.Position[0] == 65 && p.Position[1] == 5 && moveSide == 1 || p.Position[0] == 67 && p.Position[1] == 5 && moveSide == -1
            //positions de : Cocolia (dessus) & Sampo (dessous)
            || p.Position[0] == 115 && p.Position[1] == 4 && moveUpDown == -1 || p.Position[0] == 115 && p.Position[1] == 2 && moveUpDown == 1 || p.Position[0] == 114 && p.Position[1] == 3 && moveSide == 1 || p.Position[0] == 116 && p.Position[1] == 3 && moveSide == -1
            //position de Welt
            || p.Position[0] == 160 && p.Position[1] == 36 && moveUpDown == -1 || p.Position[0] == 160 && p.Position[1] == 34 && moveUpDown == 1 || p.Position[0] == 159 && p.Position[1] == 35 && moveSide == 1 || p.Position[0] == 161 && p.Position[1] == 35 && moveSide == -1
            //position du premier coffre (si non ouvert)
            || p.Position[0] == 70 && p.Position[1] == 38 && moveUpDown == -1 && init.ChestList[0].IsOpen == false || p.Position[0] == 70 && p.Position[1] == 36 && moveUpDown == 1 && init.ChestList[0].IsOpen == false || p.Position[0] == 69 && p.Position[1] == 37 && moveSide == 1 && init.ChestList[0].IsOpen == false || p.Position[0] == 71 && p.Position[1] == 37 && moveSide == -1 && init.ChestList[0].IsOpen == false
            //position du deuxième coffre (si non ouvert)
            || p.Position[0] == 110 && p.Position[1] == 31 && moveUpDown == -1 && init.ChestList[1].IsOpen == false || p.Position[0] == 110 && p.Position[1] == 29 && moveUpDown == 1 && init.ChestList[1].IsOpen == false || p.Position[0] == 109 && p.Position[1] == 30 && moveSide == 1 && init.ChestList[1].IsOpen == false || p.Position[0] == 111 && p.Position[1] == 30 && moveSide == -1 && init.ChestList[1].IsOpen == false
            //position du troisième coffre (si non ouvert)
            || p.Position[0] == 80 && p.Position[1] == 16 && moveUpDown == -1 && init.ChestList[2].IsOpen == false || p.Position[0] == 80 && p.Position[1] == 14 && moveUpDown == 1 && init.ChestList[2].IsOpen == false || p.Position[0] == 79 && p.Position[1] == 15 && moveSide == 1 && init.ChestList[2].IsOpen == false || p.Position[0] == 81 && p.Position[1] == 15 && moveSide == -1 && init.ChestList[2].IsOpen == false
            //position du quatrième coffre (si non ouvert)
            || p.Position[0] == 150 && p.Position[1] == 23 && moveUpDown == -1 && init.ChestList[3].IsOpen == false || p.Position[0] == 150 && p.Position[1] == 21 && moveUpDown == 1 && init.ChestList[3].IsOpen == false || p.Position[0] == 149 && p.Position[1] == 22 && moveSide == 1 && init.ChestList[3].IsOpen == false || p.Position[0] == 151 && p.Position[1] == 22 && moveSide == -1 && init.ChestList[3].IsOpen == false
            //position du cinquième coffre (si non ouvert)
            || p.Position[0] == 161 && p.Position[1] == 6 && moveUpDown == -1 && init.ChestList[4].IsOpen == false || p.Position[0] == 161 && p.Position[1] == 4 && moveUpDown == 1 && init.ChestList[4].IsOpen == false || p.Position[0] == 160 && p.Position[1] == 5 && moveSide == 1 && init.ChestList[4].IsOpen == false || p.Position[0] == 162 && p.Position[1] == 5 && moveSide == -1 && init.ChestList[4].IsOpen == false
            //position du sixième coffre (si non ouvert)
            || p.Position[0] == 169 && p.Position[1] == 39 && moveUpDown == -1 && init.ChestList[5].IsOpen == false || p.Position[0] == 169 && p.Position[1] == 37 && moveUpDown == 1 && init.ChestList[5].IsOpen == false || p.Position[0] == 168 && p.Position[1] == 38 && moveSide == 1 && init.ChestList[5].IsOpen == false || p.Position[0] == 170 && p.Position[1] == 38 && moveSide == -1 && init.ChestList[5].IsOpen == false
            //position du mimic
            || p.Position[0] == 155 && p.Position[1] == 31 && moveUpDown == -1 || p.Position[0] == 155 && p.Position[1] == 29 && moveUpDown == 1 || p.Position[0] == 154 && p.Position[1] == 30 && moveSide == 1 || p.Position[0] == 156 && p.Position[1] == 30 && moveSide == -1)
            {
                moveSide = 0;
                moveUpDown = 0;
            }
            p.Position[0] += moveSide;
            p.Position[1] += moveUpDown;
            Console.SetCursorPosition(p.Position[0], p.Position[1]);

            if (p.Position[0] <= 51)
            {
                p.Position[0] = 51;
            }

            else if (p.Position[0] >= 178) 
            {
                p.Position[0] = 178; 
            }

            if (p.Position[1] <= 1)
            {
                p.Position[1] = 1;
            }
            else if (p.Position[1] >= 39)
            {
                p.Position[1] = 39;
            }

            Console.CursorLeft--;

        }

        public static int interactionRadar(Player p)
        {
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    //NPCs
                    if (p.Position[0] + i - 1 == 160 && p.Position[1] + j - 1 == 35)
                    {
                        p.DetectedChestId = 0; //npc
                        return 0;
                    }
                    else if (p.Position[0] + i - 1 == 115 && p.Position[1] + j - 1 == 3)
                    {
                        p.DetectedChestId = 0;
                        return 1;
                    }
                    else if (p.Position[0] + i - 1 == 66 && p.Position[1] + j - 1 == 5 && p.WinCount < 10)
                    {
                        p.DetectedChestId = 0;
                        return 2;
                    }
                    else if (p.Position[0] + i - 1 == 66 && p.Position[1] + j - 1 == 5 && p.WinCount >= 10)
                    {
                        p.DetectedChestId = 0;
                        return 3;
                    }

                    //Chests/Mimic
                    if (p.Position[0] + i - 1 == 70 && p.Position[1] + j - 1 == 37)
                    {
                        p.DetectedChestId = 0; //chest
                        return 4;
                    }
                    else if (p.Position[0] + i - 1 == 110 && p.Position[1] + j - 1 == 30)
                    {
                        p.DetectedChestId = 1;
                        return 4;
                    }
                    else if (p.Position[0] + i - 1 == 80 && p.Position[1] + j - 1 == 15)
                    { 
                        p.DetectedChestId = 2;
                        return 4;
                    }
                    else if (p.Position[0] + i - 1 == 150 && p.Position[1] + j - 1 == 22)
                    {
                        p.DetectedChestId = 3;
                        return 4;
                    }
                
                    else if (p.Position[0] + i - 1 == 161 && p.Position[1] + j - 1 == 5)
                    {
                        p.DetectedChestId = 4;
                        return 4;
                    }
                    else if (p.Position[0] + i - 1 == 169 && p.Position[1] + j - 1 == 38)
                    {
                        p.DetectedChestId = 5;
                        return 4;
                    }
                    else if (p.Position[0] + i - 1 == 155 && p.Position[1] + j - 1 == 30)
                    {
                        p.DetectedChestId = 1;
                        return 5;
                    }
                }
            }
            return 0;
        }

        public void startFight(Player p, Initialize init)
        {

            if (p.Position[0] > 115 && p.Position[0] < 118 && p.Position[1] > 4 && p.Position[1] < 7 && Fights[0] == false) 
            {
                p.fight(init,p,0);
                Fights[0] = true;
            }

            else if (p.Position[0] > 66 && p.Position[0] < 71 && p.Position[1] > 13 && p.Position[1] < 18 && Fights[1] == false)
            {
                p.fight(init, p, 0);
                Fights[1] = true;
            }

            else if (p.Position[0] > 170 && p.Position[0] < 179 && p.Position[1] > 5 && p.Position[1] < 10 && Fights[2] == false)
            {
                p.fight(init, p, 0);
                Fights[2] = true;
            }

            else if (p.Position[0] > 145 && p.Position[0] < 150 && p.Position[1] > 8 && p.Position[1] < 13 && Fights[3] == false)
            {
                p.fight(init, p, 0);
                Fights[3] = true;
            }

            else if (p.Position[0] > 100 && p.Position[0] < 110 && p.Position[1] > 18 && p.Position[1] < 23 && Fights[4] == false)
            {
                p.fight(init, p, 0);
                Fights[4] = true;
            }

            else if (p.Position[0] > 130 && p.Position[0] < 135 && p.Position[1] > 30 && p.Position[1] < 35 && Fights[5] == false)
            {
                p.fight(init, p, 0);
                Fights[5] = true;
            }

            else if (p.Position[0] > 90 && p.Position[0] < 95 && p.Position[1] > 32 && p.Position[1] < 37 && Fights[6] == false)
            {
                p.fight(init, p, 0);
                Fights[6] = true;
            }

            else if (p.Position[0] > 115 && p.Position[0] < 118 && p.Position[1] > 4 && p.Position[1] < 7 && Fights[7] == false)
            {
                p.fight(init, p, 0);
                Fights[7] = true;
            }
            
        }
    }
}

