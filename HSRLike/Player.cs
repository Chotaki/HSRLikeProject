using System;
using System.Collections.Generic;
using System.Linq;
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

        public bool WinFight { get => _winFight; set => _winFight = value; }
        public bool InFight { get => _inFight; set => _inFight = value; }
        public int WinCount { get => _winCount; set => _winCount = value;  }
        public Character[] PlayerTeam { get => _playerTeam; set => _playerTeam = value; }
        public List<Item> Inventory { get => _inventory; set => _inventory = value; }
        public int CurrentCharacter { get => _currentCharacter; set => _currentCharacter = value; }
        public List<Enemy> FightingEnemyList { get => _fightingEnemyList; set => _fightingEnemyList = value; } 

        public Player (int winCount)
        {
            WinCount = winCount;
        }

        public void fight(int fightType)
        {
            InFight = true;

            // Fight against normal mobs
            if (fightType == 0)
            {
                Random rnd = new Random();

            } 

            // Fight against a mimic
            else if (fightType == 1)
            {

            }
            
            // Fight against Cocolia
            else if (fightType == 2)
            {

            }
        }
    }
}
