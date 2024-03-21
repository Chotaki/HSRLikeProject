using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HSRLikeProject
{
    public class Player
    {

        private bool winFight;
        private int winCount;
        private Character[] _playerTeam = new Character[4];

        public bool WinFight { get => winFight; }
        public int WinCount { get => winCount; }
        public Character[] PlayerTeam { get => _playerTeam; }
        
    }
}
