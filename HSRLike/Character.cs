using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HsrLikeProject
{
    internal class Character
    {
        private int _id;
        // characterType : 0 = dps, 1 = healer, 2 = support
        private int _characterType;
        private string _name;
        private int _hp;
        private int _atk;
        private int _def;
        private int _type;
        private bool _alive;
        private int _lvl;
        private int _xp;
        private int _energy;
        private CharacterSkill[] _skillList = new CharacterSkill[3];

        private int _itemBuffType;
        private Dictionary<int, string> _types = new Dictionary<int, string>()
        {
            { 0, "physique" },
            { 1, "feu" },
            { 2, "glace" },
            { 3, "foudre" },
            { 4, "vent" },
            { 5, "quantique" },
            { 6, "imaginaire" }
        };
        public struct CharacterSkill
        {
            // attackType : ST = 0, Blast = 1, AoE = 2, Buff = 3, Heal = 4, Shield = 5
            public int attackType;
            public float multiplier;
            public string name;
            public string desc;
        }

        public Character(int cId, int cCharaType, string cName, int cHp, int cAtk, int cDef, int cType, bool cAlive, int cLvl, int cXp, int cEnergy, CharacterSkill[] cSkillList)
        {
            _id = cId;
            _characterType = cCharaType;
            _name = cName;
            _hp = cHp;
            _atk = cAtk;
            _def = cDef;
            _type = cType;
            _alive = cAlive;
            _lvl = cLvl;
            _xp = cXp;
            _energy = cEnergy;
            _skillList = cSkillList;
        }

        public List<Character> createCharacters()
        {
            List<Character> characterList = new List<Character> { };

            // Dan Heng

            CharacterSkill danHengNormal;
            danHengNormal.attackType = 0;
            danHengNormal.multiplier = 0.8F;
            danHengNormal.name = "North Wind";
            danHengNormal.desc = "Inflige des dégats de vent équivalent à 80% de l'atk de Dan Heng à une cible unique";

            CharacterSkill danHengTec;
            danHengTec.attackType = 0;
            danHengTec.multiplier = 2.6F;
            danHengTec.name = "Torrent";
            danHengTec.desc = "Inflige des dégats de vent équivalent à 260% de l'atk de Dan Heng à une cible unique";

            CharacterSkill danHengUlt;
            danHengUlt.attackType = 0;
            danHengUlt.multiplier = 4.4F;
            danHengUlt.name = "Ethereal Dream";
            danHengUlt.desc = "Inflige des dégats de vent équivalent à 440% de l'atk de Dan Heng à une cible unique";

            CharacterSkill[] danHengSkills = [danHengNormal, danHengTec, danHengUlt];

            Character danHeng = new Character(0, 0, "Dan Heng", 120, 74, 54, 4, true, 1, 0, 0, danHengSkills);

            characterList.Add(danHeng);

            // Jing Yuan

            CharacterSkill jingYuanNormal;
            jingYuanNormal.attackType = 0;
            jingYuanNormal.multiplier = 0.8F;
            jingYuanNormal.name = "Glistening Light";
            jingYuanNormal.desc = "Inflige des dégats de foudre équivalent à 80% de l'atk de Jing Yuan à une cible unique";

            CharacterSkill jingYuanTec;
            jingYuanTec.attackType = 2;
            jingYuanTec.multiplier = 1;
            jingYuanTec.name = "Rifting Zenith";
            jingYuanTec.desc = "Inflige des dégats de foudre équivalent à l'atk de Jing Yuan à tous les ennemis";

            CharacterSkill jingYuanUlt;
            jingYuanUlt.attackType = 2;
            jingYuanUlt.multiplier = 2.2F;
            jingYuanUlt.name = "Lightbringer";
            jingYuanUlt.desc = "Inflige des dégats de foudre équivalent à 220% de l'atk de Jing Yuan à tous les ennemis";

            CharacterSkill[] jingYuanSkills = [danHengNormal, danHengTec, danHengUlt];

            Character jingYuan = new Character(1, 0, "Jing Yuan", 158, 95, 66, 3, true, 1, 0, 0, jingYuanSkills);

            characterList.Add(jingYuan);

            // Yanqing
            // Acheron
            // Trailblazer
            // Seele
            // March 7th
            // Aventurine
            // Gepard
            // Tingyun
            // Asta
            // Hanya
            // Natasha
            // Luocha
            // Lynx

            return characterList;
        }
    }
}