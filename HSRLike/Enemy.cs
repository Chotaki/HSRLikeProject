using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSRLikeProject
{
    internal class Enemy
    {
        private int _id;
        private string _name;
        private int _hp;
        private int _atk;
        private bool _alive;
        private static bool _boss;
        // à voir si passer _boss en static est la bonne solution pour régler le soucis
        private List<int> _types;

        private EnemySkill[] skillList = new EnemySkill[_boss ? 3 : 2];
        private Dictionary<int, string> enemyTypes = new Dictionary<int, string>
        {
            {0, "physique" },
            {1, "feu" },
            {2, "glace" },
            {3, "foudre" },
            {4, "vent" },
            {5, "quantique" },
            {6, "imaginaire" },
            {7,  "none"}
        };

        public Enemy(int eId, string eName, int eHp, int eAtk, bool eAlive, bool eBoss, List<int> eTypes)
        {
            _id = eId;
            _name = eName;
            _hp = eHp;
            _atk = eAtk;
            _alive = eAlive;
            _boss = eBoss;
            _types = eTypes;
        }
        public struct EnemySkill
        {
            // attackType - 0 : Single Target, 1 : Blast, 2 : AoE, 3 : None
            public int attackType;
            public float damageMultiplier;

        }

        public List<Enemy> createEnemy()
        {
            List<Enemy> enemyList = new List<Enemy> { };

            // Magoret - Trotter 

            Enemy magoret = new Enemy(1, "Magoret", 200, 12, true, false, new List<int> { 5, 4, 3 });

            enemyList.Add(magoret);

            return enemyList;
        }

    }
}
