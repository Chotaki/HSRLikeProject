using HSRLikeProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSRLike
{
    internal class UI
    {

        public static void DisplayInventory(Player p)
        {
            Console.SetCursorPosition(20, 5);
            Console.Write("Ton inventaire :");

            string[] Touche = new[] { "(A)", "(Z)", "(E)", "(R)" ,"(T)", "(y)" };
            int espacement = 6;
            for (int i = 0; i < p.Inventory.Count; i++)
            {
                Console.SetCursorPosition(55, 10 + espacement);
                Console.Write("Utiliser "+ Touche[i]+ " : " + p.Inventory[i].Name);
                Console.SetCursorPosition(70, 12 + espacement);
                Console.Write("Description :");
                Console.SetCursorPosition(70, 13 + espacement);
                Console.Write(p.Inventory[i].Description);
                espacement += 6;
            }



        }

        public static void DisplayTeam(Player p, int selection)
        {
            Console.SetCursorPosition(20, 5);
            Console.Write("Ton equipe :");

            string[] Touche = new[] { "(A)", "(Z)", "(E)", "(R)" };
            int espacement = 6;
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(22, 4 + espacement);
                if (i == selection)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(Touche[i] + p.PlayerTeam[i].Name);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                { 
                    Console.WriteLine(Touche[i] + p.PlayerTeam[i].Name);
                }
                espacement += 6;
            }

            Console.SetCursorPosition(70, 10);
            Console.Write("Nom : " + p.PlayerTeam[selection].Name + "   " + "Type : " + p.PlayerTeam[selection].CharacterTypes[p.PlayerTeam[selection].Type]);

            Console.SetCursorPosition(70, 13);
            Console.Write("Lvl : " + p.PlayerTeam[selection].Lvl + "   " + "Hp : " + p.PlayerTeam[selection].MaxHP + "  " + "ATK : " + p.PlayerTeam[selection].BaseATK + "  " + "Def : " + p.PlayerTeam[selection].Def);

            espacement = 6;
            string[] Nom = new[] { "Attaque normale : ", "Technique : ", "Ultime : "};
            for (int i = 0;i < 3; i++)
            {
            Console.SetCursorPosition(70, 10 + espacement);
            Console.Write(Nom[i] + p.PlayerTeam[selection].SkillList[i].name);
            Console.SetCursorPosition(70, 12 + espacement);
            Console.Write("Description :");
            Console.SetCursorPosition(70, 13 +espacement);
            Console.Write(p.PlayerTeam[selection].SkillList[i].desc);
                espacement += 6;
            }


        }

        public static void DisplayFight( Player p )
        {
            //Tour

            string[] Touche = new[] {"(A)","(Z)","(E)","(R)"};

            int espacement = 6;
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(25, 10 + espacement);

                Console.WriteLine(Touche[i]+ " " + p.PlayerTeam[i].Name + " " + p.PlayerTeam[i].HP);

                espacement += 6;
            }

            Console.SetCursorPosition(75 , 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(p.FightingEnemyList[0].Name);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" utilise : ");
            Console.ForegroundColor = ConsoleColor.Magenta;  
            Console.Write(p.FightingEnemyList[0].skillList[p.FightingEnemyList[0].AttackPattern].name);
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ForegroundColor= ConsoleColor.Red;
            Console.SetCursorPosition(130, 15);
            Console.Write(" ___");
            Console.SetCursorPosition(130, 16);
            Console.Write("(*^*)");
            Console.SetCursorPosition(130, 17);
            Console.Write("--|-- ");
            Console.SetCursorPosition(130, 18);
            Console.Write(" | | ");


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(65, 30);
            Console.Write(" ___");
            Console.SetCursorPosition(65, 31);
            Console.Write("(*-*)");
            Console.SetCursorPosition(65, 32);
            Console.Write("--|-- ");
            Console.SetCursorPosition(65, 33);
            Console.Write(" | | ");

            Console.ForegroundColor = ConsoleColor.Gray;

            espacement = 6;
            for (int i = 0; i < p.FightingEnemyList.Count; i++)
            {
                Console.SetCursorPosition(160, 10 + espacement);
                Console.Write(p.FightingEnemyList[i].Name);
                Console.SetCursorPosition(160, 11 + espacement);
                for (int j = 0; j < p.FightingEnemyList[i].Types.Count; j++)
                {
                    Console.Write(p.FightingEnemyList[i].enemyTypes[p.FightingEnemyList[i].Types[j]] + " ");
                }
                espacement += 6;
            }

            Console.SetCursorPosition(90, 40);
            Console.Write(p.PlayerTeam[p.CurrentCharacter].Name + " - " + p.PlayerTeam[p.CurrentCharacter].CharacterTypes[p.PlayerTeam[p.CurrentCharacter].Type]);

            Console.SetCursorPosition(30, 44);
            Console.Write("Attack normal (i) :");
            Console.SetCursorPosition(30, 45);
            Console.Write(p.PlayerTeam[p.CurrentCharacter].SkillList[0].name);

            Console.SetCursorPosition(90, 44);
            Console.Write("Technique (o) :");
            Console.SetCursorPosition(90, 45);
            Console.Write(p.PlayerTeam[p.CurrentCharacter].SkillList[1].name);

            if (p.PlayerTeam[p.CurrentCharacter].Energy == 100)
            {

            Console.SetCursorPosition(150, 44);
            Console.Write("Ultime est pret (p) :");

            }
            else
            {
                Console.SetCursorPosition(150, 44);
                Console.Write("Ultime pas pret (p) :");
            }
            Console.SetCursorPosition(150, 45);
            Console.Write(p.PlayerTeam[p.CurrentCharacter].SkillList[2].name);
            Console.SetCursorPosition(150, 46);
            Console.Write("Energie : " + p.PlayerTeam[p.CurrentCharacter].Energy + "/100");


        }

        public static void DisplayPause()
        {
            Console.SetCursorPosition(20, 20);
            Console.Write("PAUSE");

            int sizeCursor = Console.CursorSize ;
            sizeCursor = 1 ;
            Console.SetCursorPosition(20, 21);
            Console.Write("Cliquez sur Echap pour revenir au jeu.");
        }


    }
}
