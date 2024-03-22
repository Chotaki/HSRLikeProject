using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HSRLikeProject
{
    public class Enemy
    {
        private int _id;
        public int Id { get { return _id; } }
        private string _name;
        private int _hp;
        private int _atk;
        private bool _alive;
        private static bool _boss;
        private List<int> _types;
        private int _attackPattern;
        public int AttackPattern { get { return _attackPattern; } set => _attackPattern = value; }
        public int HP { get => _hp; set => _hp = value; }
        public List<int> Types { get => _types; }

        private List<EnemySkill> skillList = new List<EnemySkill> { };
        private Dictionary<int, string> enemyTypes = new Dictionary<int, string>
        {
            {0, "physique" },
            {1, "feu" },
            {2, "glace" },
            {3, "foudre" },
            {4, "vent" },
            {5, "quantique" },
            {6, "imaginaire" }
        };

        public Enemy(int eId, string eName, int eHp, int eAtk, bool eAlive, bool eBoss, List<int> eTypes, List<EnemySkill> eSkillList, int attackPattern = 0)
        {
            _id = eId;
            _name = eName;
            _hp = eHp;
            _atk = eAtk;
            _alive = eAlive;
            _boss = eBoss;
            _types = eTypes;
            skillList = eSkillList;
            _attackPattern = attackPattern;
        }
        public struct EnemySkill
        {
            // attackType - 0 : Single Target, 1 : Blast, 2 : AoE, 3 : None
            public int attackType;
            public float damageMultiplier;
            public string name;
        }

        public List<Enemy> CreateEnemy()
        {
            List<Enemy> enemyList = new List<Enemy> { };

            // Magoret - Trotter 

            EnemySkill magoretFirstSkill;
            magoretFirstSkill.attackType = 3;
            magoretFirstSkill.damageMultiplier = 0;
            magoretFirstSkill.name = "Ç—Ç—Ça fait t—trop peur";

            EnemySkill magoretSecondSkill;
            magoretSecondSkill.attackType = 3;
            magoretSecondSkill.damageMultiplier = 0;
            magoretSecondSkill.name = "À l'aide... À l'aide !";

            EnemySkill magoretThirdSkill;
            magoretThirdSkill.attackType = 3;
            magoretThirdSkill.damageMultiplier = 0;
            magoretThirdSkill.name = "Pfiou... Sauvé";

            List<EnemySkill> magoretSkills = new List<EnemySkill>() { magoretFirstSkill, magoretSecondSkill, magoretThirdSkill };

            Enemy magoret = new Enemy(1, "Magoret", 200, 12, true, false, new List<int> { 5, 4, 3 }, magoretSkills);
            enemyList.Add(magoret);

            //Marcheur de l'ombre de l'Hiver éternel - Everwinter Shadewalker

            EnemySkill marcheurSkill;
            marcheurSkill.attackType = 0;
            marcheurSkill.damageMultiplier = 1.5F;
            marcheurSkill.name = "Écrasement givrant";

            List<EnemySkill> marcheurSkills = new List<EnemySkill>() { marcheurSkill };

            Enemy marcheur = new Enemy(2, "Marcheur de l'ombre de l'Hiver éternel", 112, 12, true, false, new List<int> { 0, 1, 5 }, marcheurSkills);
            enemyList.Add(marcheur);

            //Engeance de givre - Frostspawn

            EnemySkill frostspawnSkill;
            frostspawnSkill.attackType = 0;
            frostspawnSkill.damageMultiplier = 1.5F;
            frostspawnSkill.name = "Écrasement givrant";

            List<EnemySkill> frostspawnSkills = new List<EnemySkill>() { marcheurSkill };
            Enemy frostspawn = new Enemy(3, "Engeance de givre", 45, 12, true, false, new List<int> { 1, 4 }, frostspawnSkills);
            enemyList.Add(frostspawn);

            //Mimic 

            EnemySkill mimicSkill;
            mimicSkill.attackType = 0;
            mimicSkill.damageMultiplier = 1.5F;
            mimicSkill.name = "Morsure du coffre";

            List<EnemySkill> mimicSkills = new List<EnemySkill>() { mimicSkill };
            Enemy mimic = new Enemy(4, "Mimic", 150, 20, true, false, new List<int> { 7 }, mimicSkills);
            enemyList.Add(mimic);

            //Cocolia

            EnemySkill cocoliaFirstSkill;
            cocoliaFirstSkill.attackType = 0;
            cocoliaFirstSkill.damageMultiplier = 1.5F;
            cocoliaFirstSkill.name = "Un froid à vous briser les os";

            EnemySkill cocoliaSecondSkill;
            cocoliaSecondSkill.attackType = 1;
            cocoliaSecondSkill.damageMultiplier = 4;
            cocoliaSecondSkill.name = "Courant glaçant du déchirement d'âme";

            EnemySkill cocoliaThirdSkill;
            cocoliaThirdSkill.attackType = 2;
            cocoliaThirdSkill.damageMultiplier = 2.5F;
            cocoliaThirdSkill.name = "Héraut de l'anéantissement";

            List<EnemySkill> cocoliaSkills = new List<EnemySkill>() { cocoliaFirstSkill, cocoliaSecondSkill, cocoliaThirdSkill };

            Enemy cocolia = new Enemy(5, "Cocolia", 1302, 12, true, true, new List<int> { 1, 5, 3 }, cocoliaSkills);
            enemyList.Add(cocolia);


            return enemyList;
        }
        public void Attack(Player p)
        {
            if (this.skillList.Count() == 3)
            {
                if (this.Id == 1)
                {
                    if (this.AttackPattern != 2)
                    {
                        //to do : afficher le nom de l'attaque en fonction de son attack pattern :)
                        int damage = (int)Math.Round(this._atk * this.skillList[this.AttackPattern].damageMultiplier);
                        //p.PlayerTeam[p.currentCharacter].takeDamage(damage)
                        AttackPattern += 1;
                    }
                }
                    
            }
        }

        public void takeDamage(int damage)
        {
            this.HP -= damage;
        }

    }
}
