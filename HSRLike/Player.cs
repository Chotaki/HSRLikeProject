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
        private int _detectedChestId;

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

        public int DetectedChestId { get => _detectedChestId; set => _detectedChestId = value; }

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
            bool cocoliaFightWin = false;

            InFight = true;

            while (InFight) {

                // Fight against normal mobs
                if (fightType == 0)
                {
                    Console.Clear();
                    /* Tentative de création d'équipe ennemi de taille et composition aléatoire :
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
                    }*/
                    if (!FightingEnemyList.Contains(init.EnemyList[0]))
                    {
                        FightingEnemyList.Add(init.EnemyList[0]);
                    }
                    if (!FightingEnemyList.Contains(init.EnemyList[1]))
                    {
                        FightingEnemyList.Add(init.EnemyList[1]);
                    }
                    if (!FightingEnemyList.Contains(init.EnemyList[2]))
                    {
                        FightingEnemyList.Add(init.EnemyList[2]);
                    }


                    for (int i = 0;i < FightingEnemyList.Count; i++)
                    {
                        for (int j = 0; j < p.PlayerTeam.Length; j++)
                        {
                            if (FightingEnemyList.Count > 0 && p.PlayerTeam[j].checkIfDead() == true)
                            {
                                CurrentCharacter = j;
                                UI.DisplayFight(p);
                                WaitAction = true;
                                while (WaitAction == true)
                                {
                                    ConsoleKeyInfo pressedKeyInfo = Console.ReadKey(true);
                                    ConsoleKey pressedKey = pressedKeyInfo.Key;
                                    InputManager.Events(pressedKey, p, init);
                                    if (WaitAction == false)
                                    {
                                        p.PlayerTeam[j].attack(p, init);
                                        for (int l = 0; l < FightingEnemyList.Count; l++)
                                        {
                                            p.FightingEnemyList[0].die(p);
                                        }
                                    }
                                }
                                if (FightingEnemyList.Count > 0)
                                {
                                    if (FightingEnemyList.Count > 1)
                                    {
                                        FightingEnemyList[i].Attack(p);
                                    } else if (FightingEnemyList.Count == 1)
                                    {
                                        FightingEnemyList[0].Attack(p);
                                    }
                                }
                                else if (FightingEnemyList.Count == 0 && p.PlayerTeam[j].checkIfDead() == true)
                                {
                                    WinFight = true;
                                    WinCount += 1;
                                    InFight = false;
                                    p.PlayerTeam[j].levelUp(p);
                                    init.EnemyList[0].levelBalance(init);
                                    break;
                                }
                                else if (FightingEnemyList.Count > 0 && p.PlayerTeam[j].checkIfDead() == false)
                                {
                                    InFight = false;
                                    p.PlayerTeam[j].HP = p.PlayerTeam[j].MaxHP;
                                    p.PlayerTeam[j].ATK = p.PlayerTeam[j].BaseATK;
                                    init.EnemyList[i].HP = init.EnemyList[i].MaxHP;
                                    init.EnemyList[i].AttackPattern = 0;
                                    if (i == 0)
                                    {
                                        init.EnemyList[i].Types.Add(5);
                                        init.EnemyList[i].Types.Add(4);
                                        init.EnemyList[i].Types.Add(3);
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }

                // Fight against a mimic
                else if (fightType == 1)
                {
                    if (!FightingEnemyList.Contains(init.EnemyList[3]))
                    {
                        FightingEnemyList.Add(init.EnemyList[3]);
                    }

                    Console.Clear();

                    for (int i = 0; i < PlayerTeam.Length; i++)
                    {
                        if (FightingEnemyList.Count > 0 && p.PlayerTeam[i].checkIfDead() == true)
                        {
                            CurrentCharacter = i;
                            UI.DisplayFight(p);
                            WaitAction = true;
                            while (WaitAction == true)
                            {
                                ConsoleKeyInfo pressedKeyInfo = Console.ReadKey(true);
                                ConsoleKey pressedKey = pressedKeyInfo.Key;
                                InputManager.Events(pressedKey, p, init);
                                if (WaitAction == false)
                                {
                                    p.PlayerTeam[i].attack(p, init);

                                    p.FightingEnemyList[0].die(p);

                                }
                            }
                            if (FightingEnemyList.Count > 0)
                            {
                                FightingEnemyList[0].Attack(p);
                            }
                        }
                        if (FightingEnemyList.Count == 0 && p.PlayerTeam[i].checkIfDead() == true)
                        {
                            WinFight = true;
                            WinCount += 1;
                            InFight = false;
                            p.PlayerTeam[i].levelUp(p);
                            init.EnemyList[0].levelBalance(init); 
                            break;
                        }
                        else if (FightingEnemyList.Count > 0 && p.PlayerTeam[i].checkIfDead() == false)
                        {
                            InFight = false;
                            p.PlayerTeam[i].HP = p.PlayerTeam[i].MaxHP;
                            p.PlayerTeam[i].ATK = p.PlayerTeam[i].BaseATK;
                            init.EnemyList[i].HP = init.EnemyList[i].MaxHP;
                            init.EnemyList[i].AttackPattern = 0;
                            if (i == 0)
                            {
                                init.EnemyList[i].Types.Add(5);
                                init.EnemyList[i].Types.Add(4);
                                init.EnemyList[i].Types.Add(3);
                            }
                            break;
                        }
                    }
                }
            
                // Fight against Cocolia
                else if (fightType == 2)
                {
                    if (!FightingEnemyList.Contains(init.EnemyList[4]))
                    { 
                        FightingEnemyList.Add(init.EnemyList[4]);
                    }

                    Console.Clear();

                    for (int i = 0; i < PlayerTeam.Length; i++)
                    {
                        if (FightingEnemyList.Count > 0 && p.PlayerTeam[i].checkIfDead() == true)
                        {
                            CurrentCharacter = i;
                            UI.DisplayFight(p);
                            WaitAction = true;
                            while (WaitAction == true)
                            {
                                ConsoleKeyInfo pressedKeyInfo = Console.ReadKey(true);
                                ConsoleKey pressedKey = pressedKeyInfo.Key;
                                InputManager.Events(pressedKey, p, init);
                                if (WaitAction == false)
                                {
                                    p.PlayerTeam[i].attack(p, init);

                                    p.FightingEnemyList[0].die(p);
                                    
                                }
                            }
                            if (i % 2 != 0) 
                            {
                                if (FightingEnemyList.Count > 0)
                                {
                                    FightingEnemyList[0].Attack(p);
                                }
                                                                
                            }
                        }
                        if (FightingEnemyList.Count == 0 && p.PlayerTeam[i].checkIfDead() == true)
                        {
                            InFight = false;
                            cocoliaFightWin = true;
                            Console.Clear();
                            UI.DisplayEnd(init);

                        }
                        else if (FightingEnemyList.Count > 0 && p.PlayerTeam[i].checkIfDead() == false)
                        {
                            InFight = false;
                            p.PlayerTeam[i].HP = p.PlayerTeam[i].MaxHP;
                            p.PlayerTeam[i].ATK = p.PlayerTeam[i].BaseATK;
                            init.EnemyList[4].HP = init.EnemyList[4].MaxHP;
                            init.EnemyList[4].AttackPattern = 0;
                            
                            break;
                        }
                    }
                }
            }
            if( cocoliaFightWin == false)
            {
                Console.Clear();
                Map.DisplayMap(p.PlayerTeam, init.map);
            }
        }
    }
}
