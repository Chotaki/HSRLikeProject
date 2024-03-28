using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace HSRLikeProject
{
    public class Map
    {
        private int _iMin;
        private int _jMin;

        public string[,] playerlocation = new string[241, 64];
        public int iMin { get => _iMin; set => _iMin = value; }
        public int jMin { get => _jMin; set => _jMin = value; }

        public Map () 
        {
            iMin = 10;
            jMin = 70;
        }

        public static void DisplayMap(Character[] playerTeam, string[] lines)
        {



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



            Console.SetCursorPosition(200, 12);
            int nmTeam = 0;
            int espacement = 3;
            while (nmTeam != 4) { 
                for (int i = 0; i < 4; i++)
                    {
                        Console.SetCursorPosition(200, 12 + espacement);
                        Console.WriteLine(playerTeam[i].Name);
                        Console.SetCursorPosition(193, 12+espacement);
                        Console.Write("Lvl:" + playerTeam[i].Lvl);
                        nmTeam++;
                        espacement += 3;
                    }
            }

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


        public static void Move(int moveSide, int moveUpDown, Player p) 
        {
 
            if (moveSide == 1)
            {

                p.Position[0] += 1;
                Console.SetCursorPosition(p.Position[0], p.Position[1]);
                

            }

            else if (moveSide == -1) 
            {
                p.Position[0] -= 1;
                Console.SetCursorPosition(p.Position[0], p.Position[1]);
              
            }

            if (moveUpDown == -1)
            {
                p.Position[1] -= 1;
                Console.SetCursorPosition(p.Position[0], p.Position[1]);
               
            }

            else if (moveUpDown == 1) 
            {
                p.Position[1] += 1;
                Console.SetCursorPosition(p.Position[0], p.Position[1]);
                
            }

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

    }
}

