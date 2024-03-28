using HSRLike;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using static HSRLikeProject.Character;

namespace HSRLikeProject
{
    public class Player
    {
        private bool _winFight;
        private bool _inFight;
        private int _winCount;
        private Character[] _playerTeam = new Character[4];
        private List<Item> _inventory = new List<Item>();
        private int _currentCharacter;
        private List<Enemy> _fightingEnemyList = new List<Enemy>();
        private int _selectedCharacter;
        private int _currentAction;
        private bool _waitInput;
        private int[] _position = new int[2];
        private bool _waitAction;
        private int _enemyCount;

        public bool WinFight { get => _winFight; set => _winFight = value; }
        public bool InFight { get => _inFight; set => _inFight = value; }
        public int WinCount { get => _winCount; set => _winCount = value;  }
        public Character[] PlayerTeam { get => _playerTeam; set => _playerTeam = value; }
        public List<Item> Inventory { get => _inventory; set => _inventory = value; }
        public int CurrentCharacter { get => _currentCharacter; set => _currentCharacter = value; }
        public List<Enemy> FightingEnemyList { get => _fightingEnemyList; set => _fightingEnemyList = value; } 
        public int CurrentAction { get => _currentAction; set => _currentAction = value; }
        public int SelectedCharacter { get => _selectedCharacter; set => _selectedCharacter = value; }
        public bool WaitInput { get => _waitInput; set => _waitInput = value; }
        public int[] Position { get => _position; set => _position = value; }
        public bool WaitAction { get => _waitAction; set => _waitAction = value; }
        public int EnemyCount { get => _enemyCount; set => _enemyCount = value; }

        public Player (int winCount)
        {
            WinCount = winCount;
            Position = new[] { 160, 30 };
        }
        
        public static void PlayerCharacter(Player p)
        {
            Console.SetCursorPosition(p.Position[0], p.Position[1]);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write('P');

            Console.ForegroundColor = ConsoleColor.Gray;

        }

        public void fight(Initialize init, Player p, int fightType)
        {
            InFight = true;

            while (InFight) {

                // Fight against normal mobs
                if (fightType == 0)
                {
                    Random rnd = new Random();
                    EnemyCount = rnd.Next(1, 5);

                    for (int i = 0; i < EnemyCount; i++)
                    {
                        FightingEnemyList.Add(init.EnemyList[rnd.Next(1, 3)]);
                    }
                    if (EnemyCount < 4)
                    {
                        int trotter = rnd.Next(11);
                        if (trotter == 3)
                        {
                            FightingEnemyList.Add(init.EnemyList[0]);
                        }
                    }
                    for (int i = 0; i < FightingEnemyList.Count; i++)
                    {
                        Console.WriteLine(FightingEnemyList[i].Name);
                    }

                    for (int i = 0;i < FightingEnemyList.Count; i++)
                    {
                        for (int j = 0; j < p.PlayerTeam.Length; j++)
                        {
                            if (FightingEnemyList[i].checkIfDead() == true && p.PlayerTeam[j].checkIfDead() == true)
                            {
                                for (int k = 0; k < PlayerTeam.Length; k++)
                                {
                                    if (FightingEnemyList[0].checkIfDead() == true && p.PlayerTeam[i].checkIfDead() == true)
                                    {
                                        CurrentCharacter = p.PlayerTeam[i].Id;
                                        Console.WriteLine("stp attak mon reufg");
                                        WaitAction = true;
                                        while (WaitAction == true)
                                        {
                                            ConsoleKeyInfo pressedKeyInfo = Console.ReadKey(true);
                                            ConsoleKey pressedKey = pressedKeyInfo.Key;
                                            InputManager.Events(pressedKey, p);
                                            if (WaitAction == false)
                                            {
                                                p.PlayerTeam[k].attack(p);
                                                Console.WriteLine(p.PlayerTeam[k].Name);
                                                Console.WriteLine(p.PlayerTeam[k].HP);
                                            }
                                        }
                                        for (int l = 0; l < FightingEnemyList.Count; l++)
                                        {
                                            FightingEnemyList[l].Attack(p);
                                            Console.WriteLine(FightingEnemyList[l].Name);
                                            Console.WriteLine(FightingEnemyList[l].HP);
                                        }
                                        if (FightingEnemyList.Count == 0)
                                        {

                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                // Fight against a mimic
                else if (fightType == 1)
                {
                    FightingEnemyList.Add(init.EnemyList[3]);
                    for (int i = 0; i < PlayerTeam.Length; i++)
                    {
                        if (FightingEnemyList[0].checkIfDead() == true && p.PlayerTeam[i].checkIfDead() == true)
                        {
                            CurrentCharacter = p.PlayerTeam[i].Id;
                            Console.WriteLine("Current character id" + CurrentCharacter);
                            Console.WriteLine("stp attak mon reufg");
                            WaitAction = true;
                            while (WaitAction == true)
                            {
                                ConsoleKeyInfo pressedKeyInfo = Console.ReadKey(true);
                                ConsoleKey pressedKey = pressedKeyInfo.Key;
                                InputManager.Events(pressedKey, p);
                                if (WaitAction == false)
                                {
                                    p.PlayerTeam[i].attack(p);
                                    Console.WriteLine(p.PlayerTeam[i].Name);
                                    Console.WriteLine(p.PlayerTeam[i].HP);
                                    Console.WriteLine(p.PlayerTeam[i].Id);
                                }
                            }
                            FightingEnemyList[0].Attack(p);
                            Console.WriteLine(FightingEnemyList[0].Name);
                            Console.WriteLine(FightingEnemyList[0].HP);
                        }
                    }
                }
            
                // Fight against Cocolia
                else if (fightType == 2)
                {
                    FightingEnemyList.Add(init.EnemyList[4]);
                    for (int i = 0; i < PlayerTeam.Length; i++)
                    {
                        if (FightingEnemyList[0].checkIfDead() == true && p.PlayerTeam[i].checkIfDead() == true)
                        {
                            CurrentCharacter = p.PlayerTeam[i].Id;
                            Console.WriteLine("Current character id" + CurrentCharacter);
                            Console.WriteLine("stp attak mon reufg");
                            WaitAction = true;
                            while (WaitAction == true)
                            {
                                ConsoleKeyInfo pressedKeyInfo = Console.ReadKey(true);
                                ConsoleKey pressedKey = pressedKeyInfo.Key;
                                InputManager.Events(pressedKey, p);
                                if (WaitAction == false)
                                {
                                    p.PlayerTeam[i].attack(p);
                                    Console.WriteLine(p.PlayerTeam[i].Name);
                                    Console.WriteLine(p.PlayerTeam[i].HP);
                                    Console.WriteLine(p.PlayerTeam[i].Id);
                                }
                            }
                            if (i % 2 != 0) 
                            {
                                FightingEnemyList[0].Attack(p);
                                Console.WriteLine(FightingEnemyList[0].HP);
                            }
                        }
                    }
                }
            }
        }
    }
}
