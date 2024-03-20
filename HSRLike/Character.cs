using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HSRLikeProject
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

        public List<Character> characterList = new List<Character> { };

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

            // DAN HENG - vent

            CharacterSkill danHengNormal;
            danHengNormal.attackType = 0;
            danHengNormal.multiplier = 0.8F;
            danHengNormal.name = "Lance perce-nuages : Vent du nord";
            danHengNormal.desc = "Inflige des dégats de vent équivalent à 80% de l'attaque de Dan Heng à une cible unique";

            CharacterSkill danHengTec;
            danHengTec.attackType = 0;
            danHengTec.multiplier = 2.6F;
            danHengTec.name = "Lance perce-nuages : Torrent";
            danHengTec.desc = "Inflige des dégats de vent équivalent à 260% de l'attaque de Dan Heng à une cible unique";

            CharacterSkill danHengUlt;
            danHengUlt.attackType = 0;
            danHengUlt.multiplier = 4.4F;
            danHengUlt.name = "Rêve éthéré";
            danHengUlt.desc = "Inflige des dégats de vent équivalent à 440% de l'attaque de Dan Heng à une cible unique";

            CharacterSkill[] danHengSkills = new[] { danHengNormal, danHengTec, danHengUlt };

            Character danHeng = new Character(0, 0, "Dan Heng", 120, 74, 54, 4, true, 1, 0, 0, danHengSkills);

            characterList.Add(danHeng);


            // JING YUAN - foudre

            CharacterSkill jingYuanNormal;
            jingYuanNormal.attackType = 0;
            jingYuanNormal.multiplier = 0.8F;
            jingYuanNormal.name = "Feux de la lumière";
            jingYuanNormal.desc = "Inflige des dégats de foudre équivalent à 80% de l'attaque de Jing Yuan à une cible unique";

            CharacterSkill jingYuanTec;
            jingYuanTec.attackType = 2;
            jingYuanTec.multiplier = 1;
            jingYuanTec.name = "Zénith tonitruant";
            jingYuanTec.desc = "Inflige des dégats de foudre équivalent à l'attaque de Jing Yuan à tous les ennemis";

            CharacterSkill jingYuanUlt;
            jingYuanUlt.attackType = 2;
            jingYuanUlt.multiplier = 2.2F;
            jingYuanUlt.name = "Porteur de lumière";
            jingYuanUlt.desc = "Inflige des dégats de foudre équivalent à 220% de l'attaque de Jing Yuan à tous les ennemis";

            CharacterSkill[] jingYuanSkills = new[] { jingYuanNormal, jingYuanTec, jingYuanUlt };

            Character jingYuan = new Character(1, 0, "Jing Yuan", 158, 95, 66, 3, true, 1, 0, 0, jingYuanSkills);

            characterList.Add(jingYuan);


            // YANQING - glace

            CharacterSkill yanqingNormal;
            yanqingNormal.attackType = 0;
            yanqingNormal.multiplier = 0.8F;
            yanqingNormal.name = "Épine de givre";
            yanqingNormal.desc = "Inflige des dégats de glace équivalent à 80% de l'attaque de Yanqing à une cible unique";

            CharacterSkill yanqingTec;
            yanqingTec.attackType = 0;
            yanqingTec.multiplier = 2.2F;
            yanqingTec.name = "Salve d'aiguillons";
            yanqingTec.desc = "Inflige des dégats de glace équivalent à 220% de l'attaque de Yanqing à une cible";

            CharacterSkill yanqingUlt;
            yanqingUlt.attackType = 0;
            yanqingUlt.multiplier = 3.8F;
            yanqingUlt.name = "Béatitude au milieu de l'averse";
            yanqingUlt.desc = "Inflige des dégats de glace équivalent à 380% de l'attaque de Yanqing à une cible";

            CharacterSkill[] yanqingSkills = new[] { yanqingNormal, yanqingTec, yanqingUlt };

            Character yanqing = new Character(2, 0, "Yanqing", 121, 92, 56, 2, true, 1, 0, 0, yanqingSkills);

            characterList.Add(yanqing);


            // ACHERON - foudre

            CharacterSkill acheronNormal;
            acheronNormal.attackType = 0;
            acheronNormal.multiplier = 0.8F;
            acheronNormal.name = "Wiltcross trilatéral";
            acheronNormal.desc = "Inflige des dégats de foudre équivalent à 80% de l'attaque d'Acheron à une cible unique";

            CharacterSkill acheronTec;
            acheronTec.attackType = 1;
            acheronTec.multiplier = 1.6F;
            acheronTec.name = "Flash octobolt";
            acheronTec.desc = "Inflige des dégats de foudre équivalent à 160% de l'attaque d'Acheron à un ennemi et 60% de son atk aux ennemis adjacents";

            CharacterSkill acheronUlt;
            acheronUlt.attackType = 2;
            acheronUlt.multiplier = 4;
            acheronUlt.name = "Un rêve coupé pleure en rouge";
            acheronUlt.desc = "Inflige des dégats de foudre équivalent à 400% de l'attaque d'Acheron à tous les ennemis";

            CharacterSkill[] acheronSkills = new[] { acheronNormal, acheronTec, acheronUlt };

            Character acheron = new Character(3, 0, "Acheron", 153, 95, 59, 3, true, 1, 0, 0, acheronSkills);

            characterList.Add(acheron);


            // TRAILBLAZER - physique

            CharacterSkill trailblazerNormal;
            trailblazerNormal.attackType = 0;
            trailblazerNormal.multiplier = 0.8F;
            trailblazerNormal.name = "Coup d'adieu";
            trailblazerNormal.desc = "Inflige des dégats physiques équivalent à 80% de l'attaque du Trailblazer à une cible unique";

            CharacterSkill trailblazerTec;
            trailblazerTec.attackType = 1;
            trailblazerTec.multiplier = 1.25F;
            trailblazerTec.name = "Home run final";
            trailblazerTec.desc = "Inflige des dégats physiques équivalent à 125% de l'attaque du Trailblazer à un ennemi ainsi qu'aux ennemis adjacents";

            CharacterSkill trailblazerUlt;
            trailblazerUlt.attackType = 0;
            trailblazerUlt.multiplier = 5.4F;
            trailblazerUlt.name = "Lançeur de poussière d'étoile";
            trailblazerUlt.desc = "Inflige des dégats physiques équivalent à 540% de l'attaque du Trailblazer à une cible unique";

            CharacterSkill[] trailblazerSkills = new[] { trailblazerNormal, trailblazerTec, trailblazerUlt };

            Character trailblazer = new Character(4, 0, "Trailblazer", 164, 84, 62, 0, true, 1, 0, 0, trailblazerSkills);

            characterList.Add(trailblazer);


            // SEELE - quantique

            CharacterSkill seeleNormal;
            seeleNormal.attackType = 0;
            seeleNormal.multiplier = 0.8F;
            seeleNormal.name = "Représailles";
            seeleNormal.desc = "Inflige des dégats quantiques équivalent à 80% de l'attaque de Seele à une cible unique";

            CharacterSkill seeleTec;
            seeleTec.attackType = 0;
            seeleTec.multiplier = 2.2F;
            seeleTec.name = "Lame rengainée";
            seeleTec.desc = "Inflige des dégats quantiques équivalent à 220% de l'attaque de Seele à une cible unique";

            CharacterSkill seeleUlt;
            seeleUlt.attackType = 0;
            seeleUlt.multiplier = 3.5F;
            seeleUlt.name = "Volée de papillons";
            seeleUlt.desc = "Inflige des dégats quantiques équivalent à 350% de l'attaque de Seele à une cible unique";

            CharacterSkill[] seeleSkills = new[] { seeleNormal, seeleTec, seeleUlt };

            Character seele = new Character(5, 0, "Seele", 127, 87, 49, 5, true, 1, 0, 0, seeleSkills);

            characterList.Add(seele);


            // MARCH 7TH - glace

            CharacterSkill marchNormal;
            marchNormal.attackType = 0;
            marchNormal.multiplier = 0.8F;
            marchNormal.name = "Flèche du froid glacial";
            marchNormal.desc = "Inflige des dégats de glace équivalent à 80% de l'attaque de March 7th à une cible unique";

            CharacterSkill marchTec;
            marchTec.attackType = 5;
            marchTec.multiplier = 0.7F;
            marchTec.name = "Par le pouvoir de la mignonnerie";
            marchTec.desc = "Applique un bouclier équivalent à 70% de la défense de March 7th à un allié";

            CharacterSkill marchUlt;
            marchUlt.attackType = 2;
            marchUlt.multiplier = 1.6F;
            marchUlt.name = "Cascade glaciale";
            marchUlt.desc = "Inflige des dégats de glace équivalent à 160% de l'attaque de March 7th à tous les ennemis";

            CharacterSkill[] marchSkills = new[] { marchNormal, marchTec, marchUlt };

            Character march = new Character(6, 2, "March 7th", 144, 69, 78, 2, true, 1, 0, 0, marchSkills);

            characterList.Add(march);


            // AVENTURINE - imaginaire

            CharacterSkill aventurineNormal;
            aventurineNormal.attackType = 0;
            aventurineNormal.multiplier = 0.8F;
            aventurineNormal.name = "Pari direct";
            aventurineNormal.desc = "Inflige des dégats imaginaires équivalent à 80% de l'attaque d'Aventurine à une cible unique";

            CharacterSkill aventurineTec;
            aventurineTec.attackType = 5;
            aventurineTec.multiplier = 0.9F;
            aventurineTec.name = "Pierre angulaire de luxe";
            aventurineTec.desc = "Applique un bouclier équivalent à 90% de la défense d'Aventurine à tous les alliés";

            CharacterSkill aventurineUlt;
            aventurineUlt.attackType = 0;
            aventurineUlt.multiplier = 2.9F;
            aventurineUlt.name = "La roulette du requin";
            aventurineUlt.desc = "Inflige des dégats imaginaires équivalent à 290% de la défense d'Aventurine à une cible unique";

            CharacterSkill[] aventurineSkills = new[] { aventurineNormal, aventurineTec, aventurineUlt };

            Character aventurine = new Character(7, 2, "Aventurine", 164, 60, 89, 6, true, 1, 0, 0, aventurineSkills);

            characterList.Add(aventurine);


            // GEPARD - glace

            CharacterSkill gepardNormal;
            gepardNormal.attackType = 0;
            gepardNormal.multiplier = 0.8F;
            gepardNormal.name = "Poing de la conviction";
            gepardNormal.desc = "Inflige des dégats de glace équivalent à 80% de l'attaque de Gepard à une cible unique";

            CharacterSkill gepardTec;
            gepardTec.attackType = 0;
            gepardTec.multiplier = 2;
            gepardTec.name = "Frappe intimidante";
            gepardTec.desc = "Inflige des dégats de glace équivalent à 200% de l'attaque de Gepard à une cible unique";

            CharacterSkill gepardUlt;
            gepardUlt.attackType = 5;
            gepardUlt.multiplier = 0.75F;
            gepardUlt.name = "Rempart d'endurance";
            gepardUlt.desc = "Applique un bouclier équivalent à 75% de la défense de Gepard à tous les alliés";

            CharacterSkill[] gepardSkills = new[] { gepardNormal, gepardTec, gepardUlt };

            Character gepard = new Character(8, 2, "Gepard", 190, 73, 89, 2, true, 1, 0, 0, gepardSkills);

            characterList.Add(gepard);


            // TINGYUN - foudre

            CharacterSkill tingyunNormal;
            tingyunNormal.attackType = 0;
            tingyunNormal.multiplier = 0.8F;
            tingyunNormal.name = "Expulsion";
            tingyunNormal.desc = "Inflige des dégats de foudre équivalent à 80% de l'attaque de Tingyun à une cible unique";

            CharacterSkill tingyunTec;
            tingyunTec.attackType = 3;
            tingyunTec.multiplier = 0.4F;
            tingyunTec.name = "Mélodie apaisante";
            tingyunTec.desc = "Donne un boost d'attaque équivalent à 40% de l'attaque de Tingyun à un allié";

            CharacterSkill tingyunUlt;
            tingyunUlt.attackType = 3;
            tingyunUlt.multiplier = 1.38F;
            tingyunUlt.name = "Bienveillance des nuages";
            tingyunUlt.desc = "Donne un boost d'attaque équivalent à 138% de l'attaque de Tingyun et 40 point d'énergie à un allié";

            CharacterSkill[] tingyunSkills = new[] { tingyunNormal, tingyunTec, tingyunUlt };

            Character tingyun = new Character(9, 2, "Tingyun", 115, 72, 54, 3, true, 1, 0, 0, tingyunSkills);

            characterList.Add(tingyun);


            // ASTA - feu

            CharacterSkill astaNormal;
            astaNormal.attackType = 0;
            astaNormal.multiplier = 0.8F;
            astaNormal.name = "Rayon spectral";
            astaNormal.desc = "Inflige des dégats de feu équivalent à 80% de l'attaque d'Asta à une cible unique";

            CharacterSkill astaTec;
            astaTec.attackType = 0;
            astaTec.multiplier = 0.6F;
            astaTec.name = "Tempête de météores";
            astaTec.desc = "Inflige 5 fois des dégats de feu équivalent à 60% de l'attaque d'Asta à une cible unique";

            CharacterSkill astaUlt;
            astaUlt.attackType = 3;
            astaUlt.multiplier = 1.44F;
            astaUlt.name = "Bénédiction astrale";
            astaUlt.desc = "Donne un boost d'attaque équivalent à 144% de l'attaque d'Asta à tous les alliés";

            CharacterSkill[] astaSkills = new[] { astaNormal, astaTec, astaUlt };

            Character asta = new Character(10, 2, "Asta", 139, 69, 63, 1, true, 1, 0, 0, astaSkills);

            characterList.Add(asta);


            // HANYA - physique

            CharacterSkill hanyaNormal;
            hanyaNormal.attackType = 0;
            hanyaNormal.multiplier = 0.8F;
            hanyaNormal.name = "Pinceau divin";
            hanyaNormal.desc = "Inflige des dégats physiques équivalent à 80% de l'attaque d'Hanya à une cible unique";

            CharacterSkill hanyaTec;
            hanyaTec.attackType = 0;
            hanyaTec.multiplier = 2.4F;
            hanyaTec.name = "Emprisonnement d'âme";
            hanyaTec.desc = "Inflige des dégats physiques équivalent à 240% de l'attaque d'Hanya à une cible unique";

            CharacterSkill hanyaUlt;
            hanyaUlt.attackType = 3;
            hanyaUlt.multiplier = 1.5F;
            hanyaUlt.name = "Sentence universelle";
            hanyaUlt.desc = "Donne un boost d'attaque équivalent à 150% de l'attaque d'Hanya à un allié";

            CharacterSkill[] hanyaSkills = new[] { hanyaNormal, hanyaTec, hanyaUlt };

            Character hanya = new Character(11, 2, "Hanya", 125, 76, 48, 0, true, 1, 0, 0, hanyaSkills);

            characterList.Add(hanya);


            // NATASHA - physique

            CharacterSkill natashaNormal;
            natashaNormal.attackType = 0;
            natashaNormal.multiplier = 0.8F;
            natashaNormal.name = "Derrière la bonté";
            natashaNormal.desc = "Inflige des dégats physiques équivalent à 80% de l'attaque de Natasha à une cible unique";

            CharacterSkill natashaTec;
            natashaTec.attackType = 4;
            natashaTec.multiplier = 0.09F;
            natashaTec.name = "Aimer, guérir et choisir";
            natashaTec.desc = "Soigne un allié à hauteur de 9% des pv max de Natasha";

            CharacterSkill natashaUlt;
            natashaUlt.attackType = 4;
            natashaUlt.multiplier = 0.12F;
            natashaUlt.name = "Cadeau de la renaissance";
            natashaUlt.desc = "Soigne tous les alliés à hauteur de 12% des pv max de Natasha";

            CharacterSkill[] natashaSkills = new[] { natashaNormal, natashaTec, natashaUlt };

            Character natasha = new Character(12, 1, "Natasha", 158, 64, 69, 0, true, 1, 0, 0, natashaSkills);

            characterList.Add(natasha);


            // LUOCHA - imaginaire

            CharacterSkill luochaNormal;
            luochaNormal.attackType = 0;
            luochaNormal.multiplier = 0.8F;
            luochaNormal.name = "Épines de l'abîme";
            luochaNormal.desc = "Inflige des dégats imaginaires équivalent à 80% de l'attaque de Luocha à une cible unique";

            CharacterSkill luochaTec;
            luochaTec.attackType = 4;
            luochaTec.multiplier = 0.55F;
            luochaTec.name = "Prière de la Fleur de l'abîme";
            luochaTec.desc = "Soigne un allié à hauteur de 55% de l'attaque de Luocha";

            CharacterSkill luochaUlt;
            luochaUlt.attackType = 2;
            luochaUlt.multiplier = 2.3F;
            luochaUlt.name = "Pulsion de mort";
            luochaUlt.desc = "Inflige des dégats imaginaires équivalent à 230% de l'attaque de Luocha à tous les ennemis";

            CharacterSkill[] luochaSkills = new[] { luochaNormal, luochaTec, luochaUlt };

            Character luocha = new Character(13, 1, "Luocha", 174, 102, 49, 6, true, 1, 0, 0, luochaSkills);

            characterList.Add(luocha);


            // LYNX - quantique

            CharacterSkill lynxNormal;
            lynxNormal.attackType = 0;
            lynxNormal.multiplier = 0.8F;
            lynxNormal.name = "Attaque au pic à glace";
            lynxNormal.desc = "Inflige des dégats quantiques équivalent à 80% de l'attaque de Lynx à une cible unique";

            CharacterSkill lynxTec;
            lynxTec.attackType = 4;
            lynxTec.multiplier = 0.1F;
            lynxTec.name = "Sardines en conserve";
            lynxTec.desc = "Soigne un allié à hauteur de 10% des pv max de Lynx";

             CharacterSkill lynxUlt;
            lynxUlt.attackType = 4;
            lynxUlt.multiplier = 0.12F;
            lynxUlt.name = "Plan de secours des Plaines des neiges";
            lynxUlt.desc = "Soigne tous les alliés à hauteur de 12% des pv max de Lynx";

            CharacterSkill[] lynxSkills = new[] { lynxNormal, lynxTec, lynxUlt };

            Character lynx = new Character(14, 1, "Lynx", 144, 67, 75, 5, true, 1, 0, 0, lynxSkills);

            characterList.Add(lynx);


            return characterList;
        }

        public float normalAttack(int attackerId)
        {
            float damage;

            damage = 0; 
            /*  
            Liste de personnage -> un personnage -> skillSet -> normalAttack -> multiplier
            Liste de personnage -> un personnage -> atk
            */

          /*  for (int i = 0; i < characterList.size; i++)
            {
                int attacker = characterList.get(i);
                Character currentAttacker = attacker.get(Character);
                if (attackerId = attacker.get(_id))
                {
                    attacker.get(_skillList[0].multiplier);
                }
            }*/

            //PropertyInfo[] properties = typeof(Character).GetType().GetProperties();

            return damage;
        }

        public bool die()
        {
            if (_hp == 0) {
                _alive = false;
            } else {
                _alive = true;
            }

            return _alive;
        }
    }
}