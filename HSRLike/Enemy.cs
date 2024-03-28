using HSRLike;
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
        public string Name { get { return _name; } }
        public int AttackPattern { get { return _attackPattern; } set => _attackPattern = value; }
        public int HP { get => _hp; set => _hp = value; }
        public int Atk { get => _atk; set =>  _atk = value; }
        public bool Alive { get => _alive; set => _alive = value; }
        public List<int> Types { get => _types; }

        public List<EnemySkill> skillList = new List<EnemySkill> { };
        public Dictionary<int, string> enemyTypes = new Dictionary<int, string>
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
            // attackType - 0 : Single Target, 1 : Blast, 2 : AoE
            public int attackType;
            public float damageMultiplier;
            public string name;
        }

/*        public List<Enemy> CreateEnemy()
        {
            List<Enemy> enemyList = new List<Enemy> { };

            // Magoret - Trotter 

            EnemySkill magoretFirstSkill;
            magoretFirstSkill.attackType = 0;
            magoretFirstSkill.damageMultiplier = 0;
            magoretFirstSkill.name = "Ç—Ç—Ça fait t—trop peur";

            EnemySkill magoretSecondSkill;
            magoretSecondSkill.attackType = 0;
            magoretSecondSkill.damageMultiplier = 0;
            magoretSecondSkill.name = "À l'aide... À l'aide !";

            EnemySkill magoretThirdSkill;
            magoretThirdSkill.attackType = 0;
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
            cocoliaSecondSkill.damageMultiplier = 0.75F;
            cocoliaSecondSkill.name = "Courant glaçant du déchirement d'âme";

            EnemySkill cocoliaThirdSkill;
            cocoliaThirdSkill.attackType = 2;
            cocoliaThirdSkill.damageMultiplier = 2.5F;
            cocoliaThirdSkill.name = "Héraut de l'anéantissement";

            List<EnemySkill> cocoliaSkills = new List<EnemySkill>() { cocoliaFirstSkill, cocoliaSecondSkill, cocoliaThirdSkill };

            Enemy cocolia = new Enemy(5, "Cocolia", 1302, 12, true, true, new List<int> { 1, 5, 3 }, cocoliaSkills);
            enemyList.Add(cocolia);


            return enemyList;
        }*/
        public void Attack(Player p)
        {
            bool isAttackDone = false;
            int damage;
            if (this.skillList.Count() == 3)
            {
                if (this.Id == 1)
                {
                    if (this.AttackPattern == 0)
                    {
                        //to do : afficher le nom de l'attaque en fonction de son attack pattern :)
                        //comme les magorets n'attaquent pas, ils n'infligent pas de dégâts, therefore pas de dégâts à infliger
                        AttackPattern += 1;
                        isAttackDone = true;
                    }
                    else if (this.AttackPattern == 1)
                    {
                        this.Types.Clear();
                        isAttackDone = true;
                    }
                    else
                    {
                        this.die(p);
                    }
                }
                else
                {
                    do
                    {
                        Random randomAttack = new Random();
                        int result = randomAttack.Next(1, 10);
                        if (1 <= result && result < 8)
                        {
                            //to do : afficher le nom de l'attaque en fonction de son attack pattern :)
                            damage = (int)Math.Round(this.Atk * this.skillList[this.AttackPattern].damageMultiplier - p.PlayerTeam[p.CurrentCharacter].Def / 100);
                            p.PlayerTeam[p.CurrentCharacter].takeDamage(damage);
                            isAttackDone = true;
                        }
                        else if (8 <= result && result < 10 && this.AttackPattern != 1)
                        {
                            //to do : afficher le nom de l'attaque en fonction de son attack pattern :)
                            this.AttackPattern = 1;
                            damage = (int)Math.Round(this.Atk * this.skillList[this.AttackPattern].damageMultiplier - p.PlayerTeam[p.CurrentCharacter].Def / 100);
                            p.PlayerTeam[p.CurrentCharacter].takeDamage(damage);
                            for (int i = 1; i < 3; i++)
                            {
                                if (p.PlayerTeam[p.CurrentCharacter + i].checkIfDead() == false && p.CurrentCharacter + i <= p.PlayerTeam.Length)
                                {
                                    damage = (int)Math.Round(this.Atk * this.skillList[this.AttackPattern].damageMultiplier - p.PlayerTeam[p.CurrentCharacter + i].Def / 100);
                                    p.PlayerTeam[p.CurrentCharacter + i].takeDamage(damage);                         
                                    
                                }
                                else
                                {
                                    break;
                                }
                            }
                            isAttackDone = true;
                        }
                        else if (result == 10 && this.AttackPattern != 2)
                        {
                            //to do : afficher le nom de l'attaque en fonction de son attack pattern :)
                            this.AttackPattern = 2;
                            damage = (int)Math.Round(this.Atk * this.skillList[this.AttackPattern].damageMultiplier - p.PlayerTeam[p.CurrentCharacter].Def / 100);
                            for (int i = 0; i < p.PlayerTeam.Length - 1; i++)
                            {
                                if (!p.PlayerTeam[i].checkIfDead())
                                {
                                    p.PlayerTeam[i].takeDamage(damage);
                                }
                            }
                            isAttackDone = true;
                        }
                        else
                        {
                            break;
                        }
                    } while (isAttackDone != true);

                }
                    
            }
            else
            {
                damage = (int)Math.Round(this.Atk * this.skillList[this.AttackPattern].damageMultiplier - p.PlayerTeam[p.CurrentCharacter].Def / 100);
                p.PlayerTeam[p.CurrentCharacter].takeDamage(damage);
            }
        }

        public void takeDamage(int damage)
        {
            this.HP -= damage;
        }

        public bool checkIfDead()
        {
            if (this.HP <= 0)
            {
                this.Alive = false;
            }
            else
            {
                this.Alive = true;
            }

            return this.Alive;
        }

        public void die(Player p) //*élimine l'ennemi s'il n'a plus d'hp ou qu'il disparaît cf. magoretThirdSkill*
        {
            Console.WriteLine("{0} est mort au combat", p.FightingEnemyList[0].Name);
            p.FightingEnemyList.RemoveAt(0);
        }
       
        /*public void levelBalance (Initialize init)
        {
            for (int i = 0;  i < init.EnemyList.Count - 1; i++)
            {
                init.EnemyList[i].HP += 67;
                init.EnemyList[i].Atk += 25;
            }
        }*/

    }
}
