using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HSRLikeProject
{
    public class Player
    {
        private bool _winFight;
        private int _winCount;
        private Character[] _playerTeam = new Character[4];
        private int _currentCharacter;
        private List<Enemy> _enemyList = new List<Enemy>();

        public bool WinFight { get => _winFight; }
        public int WinCount { get => _winCount; }
        public Character[] PlayerTeam { get => _playerTeam; }
        public int CurrentCharacter { get => _currentCharacter; set => _currentCharacter = value; }
        public List<Enemy> enemies { get => _enemyList; set => _enemyList = value; }
    }
}
