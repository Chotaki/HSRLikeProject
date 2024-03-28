using HSRLikeProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HSRLikeProject.Character;
using static HSRLikeProject.Enemy;

namespace HSRLike
{
    public class Initialize
    {
        private List<Enemy> _enemyList = new List<Enemy>();
        private List<Character> _characterList = new List<Character> { };
        private List<Item> _itemList = new List<Item>();
        private List<Chest> _chestList = new List<Chest>();
        private List<NPC> _npcList = new List<NPC>();

        public List<Enemy> EnemyList { get => _enemyList; set => _enemyList = value; }
        public List<Character> CharacterList { get => _characterList; set => _characterList = value; }
        public List<Item> ItemList { get => _itemList; set => _itemList = value; }
        public List<Chest> ChestList { get => _chestList; set => _chestList = value; }
        public List<NPC> NPCList { get => _npcList; set => _npcList = value; }

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

            Character danHeng = new Character(0, 0, "Dan Heng", 120, 74, 54, 4, true, 1, 0, danHengSkills);

            CharacterList.Add(danHeng);


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

            Character jingYuan = new Character(1, 0, "Jing Yuan", 158, 95, 66, 3, true, 1, 0, jingYuanSkills);

            CharacterList.Add(jingYuan);




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

            Character yanqing = new Character(2, 0, "Yanqing", 121, 92, 56, 2, true, 1, 0, yanqingSkills);

            CharacterList.Add(yanqing);


            // ACHERON - foudre

            CharacterSkill acheronNormal;
            acheronNormal.attackType = 0;
            acheronNormal.multiplier = 0.8F;
            acheronNormal.name = "Flétrissement des trois sagesses";
            acheronNormal.desc = "Inflige des dégats de foudre équivalent à 80% de l'attaque d'Acheron à une cible unique";

            CharacterSkill acheronTec;
            acheronTec.attackType = 1;
            acheronTec.multiplier = 1.6F;
            acheronTec.name = "Eclair multiple";
            acheronTec.desc = "Inflige des dégats de foudre équivalent à 160% de l'attaque d'Acheron à un ennemi et 60% de son atk aux deux ennemis suivants";

            CharacterSkill acheronUlt;
            acheronUlt.attackType = 2;
            acheronUlt.multiplier = 4;
            acheronUlt.name = "Rêve flétri écarlate";
            acheronUlt.desc = "Inflige des dégats de foudre équivalent à 400% de l'attaque d'Acheron à tous les ennemis";

            CharacterSkill[] acheronSkills = new[] { acheronNormal, acheronTec, acheronUlt };

            Character acheron = new Character(3, 0, "Acheron", 153, 95, 59, 3, true, 1, 0, acheronSkills);

            CharacterList.Add(acheron);


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
            trailblazerTec.desc = "Inflige des dégats physiques équivalent à 125% de l'attaque du Trailblazer à un ennemi ainsi qu'aux deux ennemis suivants";

            CharacterSkill trailblazerUlt;
            trailblazerUlt.attackType = 0;
            trailblazerUlt.multiplier = 5.4F;
            trailblazerUlt.name = "Lançeur de poussière d'étoile";
            trailblazerUlt.desc = "Inflige des dégats physiques équivalent à 540% de l'attaque du Trailblazer à une cible unique";

            CharacterSkill[] trailblazerSkills = new[] { trailblazerNormal, trailblazerTec, trailblazerUlt };

            Character trailblazer = new Character(4, 0, "Trailblazer", 164, 84, 62, 0, true, 1, 0, trailblazerSkills);

            CharacterList.Add(trailblazer);


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

            Character seele = new Character(5, 0, "Seele", 127, 87, 49, 5, true, 1, 0, seeleSkills);

            CharacterList.Add(seele);


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

            Character march = new Character(6, 2, "March 7th", 144, 69, 78, 2, true, 1, 0, marchSkills);

            CharacterList.Add(march);


            // AVENTURINE - imaginaire

            CharacterSkill aventurineNormal;
            aventurineNormal.attackType = 0;
            aventurineNormal.multiplier = 0.8F;
            aventurineNormal.name = "Pari direct";
            aventurineNormal.desc = "Inflige des dégats imaginaires équivalent à 80% de l'attaque d'Aventurine à une cible unique";

            CharacterSkill aventurineTec;
            aventurineTec.attackType = 5;
            aventurineTec.multiplier = 0.9F;
            aventurineTec.name = "Pierre angulaire de la prospérité";
            aventurineTec.desc = "Applique un bouclier équivalent à 90% de la défense d'Aventurine à tous les alliés";

            CharacterSkill aventurineUlt;
            aventurineUlt.attackType = 0;
            aventurineUlt.multiplier = 2.9F;
            aventurineUlt.name = "Roi de la roulette";
            aventurineUlt.desc = "Inflige des dégats imaginaires équivalent à 290% de la défense d'Aventurine à une cible unique";

            CharacterSkill[] aventurineSkills = new[] { aventurineNormal, aventurineTec, aventurineUlt };

            Character aventurine = new Character(7, 2, "Aventurine", 164, 60, 89, 6, true, 1, 0, aventurineSkills);

            CharacterList.Add(aventurine);


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

            Character gepard = new Character(8, 2, "Gepard", 190, 73, 89, 2, true, 1, 0, gepardSkills);

            CharacterList.Add(gepard);


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

            Character tingyun = new Character(9, 3, "Tingyun", 115, 72, 54, 3, true, 1, 0, tingyunSkills);

            CharacterList.Add(tingyun);


            // ASTA - feu

            CharacterSkill astaNormal;
            astaNormal.attackType = 0;
            astaNormal.multiplier = 0.8F;
            astaNormal.name = "Rayon spectral";
            astaNormal.desc = "Inflige des dégats de feu équivalent à 80% de l'attaque d'Asta à une cible unique";

            CharacterSkill astaTec;
            astaTec.attackType = 6;
            astaTec.multiplier = 0.6F;
            astaTec.name = "Tempête de météores";
            astaTec.desc = "Inflige des dégats de feu équivalent à 60% de l'attaque d'Asta 5 fois aléatoirement aux ennemis";

            CharacterSkill astaUlt;
            astaUlt.attackType = 3;
            astaUlt.multiplier = 1.44F;
            astaUlt.name = "Bénédiction astrale";
            astaUlt.desc = "Donne un boost d'attaque équivalent à 144% de l'attaque d'Asta à tous les alliés";

            CharacterSkill[] astaSkills = new[] { astaNormal, astaTec, astaUlt };

            Character asta = new Character(10, 3, "Asta", 139, 69, 63, 1, true, 1, 0, astaSkills);

            CharacterList.Add(asta);


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

            Character hanya = new Character(11, 3, "Hanya", 125, 76, 48, 0, true, 1, 0, hanyaSkills);

            CharacterList.Add(hanya);


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

            Character natasha = new Character(12, 1, "Natasha", 158, 64, 69, 0, true, 1, 0, natashaSkills);

            CharacterList.Add(natasha);


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

            Character luocha = new Character(13, 1, "Luocha", 174, 102, 49, 6, true, 1, 0, luochaSkills);

            CharacterList.Add(luocha);


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

            Character lynx = new Character(14, 1, "Lynx", 144, 67, 75, 5, true, 1, 0, lynxSkills);

            CharacterList.Add(lynx);


            return CharacterList;
        }

        public List<Enemy> CreateEnemy()
        {

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
            _enemyList.Add(magoret);

            //Marcheur de l'ombre de l'Hiver éternel - Everwinter Shadewalker

            EnemySkill marcheurSkill;
            marcheurSkill.attackType = 0;
            marcheurSkill.damageMultiplier = 1.5F;
            marcheurSkill.name = "Écrasement givrant";

            List<EnemySkill> marcheurSkills = new List<EnemySkill>() { marcheurSkill };

            Enemy marcheur = new Enemy(2, "Marcheur de l'ombre de l'Hiver éternel", 112, 12, true, false, new List<int> { 0, 1, 5 }, marcheurSkills);
            _enemyList.Add(marcheur);

            //Engeance de givre - Frostspawn

            EnemySkill frostspawnSkill;
            frostspawnSkill.attackType = 0;
            frostspawnSkill.damageMultiplier = 1.5F;
            frostspawnSkill.name = "Écrasement givrant";

            List<EnemySkill> frostspawnSkills = new List<EnemySkill>() { marcheurSkill };
            Enemy frostspawn = new Enemy(3, "Engeance de givre", 45, 12, true, false, new List<int> { 1, 4 }, frostspawnSkills);
            _enemyList.Add(frostspawn);

            //Mimic 

            EnemySkill mimicSkill;
            mimicSkill.attackType = 0;
            mimicSkill.damageMultiplier = 1.5F;
            mimicSkill.name = "Morsure du coffre";

            List<EnemySkill> mimicSkills = new List<EnemySkill>() { mimicSkill };
            Enemy mimic = new Enemy(4, "Mimic", 150, 20, true, false, new List<int> { 7 }, mimicSkills);
            _enemyList.Add(mimic);

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

            Enemy cocolia = new Enemy(5, "Cocolia", 25000, 100, true, true, new List<int> { 1, 5, 3 }, cocoliaSkills);
            _enemyList.Add(cocolia);

            return _enemyList;
        }

        public List<Item> createItems()
        {
            // 0 = 2 star; 1 = 3 star; 2 = 4 star

            Item brasCinétique = new Item(0, "Bras Cinétique Jetable",
                "Après utilisation, donne un boost de 325 d'attaque à tous les membres de l'équipe pour le prochain combat",
                1, 0, 325, 0, 2);
            ItemList.Add(brasCinétique);

            Item cone = new Item(1, "Cône de Rêves (Trois Parfums)",
                "Après utilisation, donne un boost de 60% d'attaque à tous les membres de l'équipe pour le prochain combat",
                1, 1, 0, 0.6F, 2);
            ItemList.Add(cone);

            Item generator = new Item(2, "Générateur de Champ d'Antimatière",
                "Après utilisation, donne un boost de 260 d'attaque à tous les membres de l'équipe pour le prochain combat", 
                1, 0, 260, 0, 1);
            ItemList.Add(generator);

            Item gratteDos = new Item(3, "Gratte-dos",
                "Après utilisation, donne un boost de 190 d'attaque à tous les membres de l'équipe pour le prochain combat", 
                1, 0, 190, 0, 1);
            ItemList.Add(gratteDos);

            Item amuseBouche = new Item(4, "Amuse-bouche à la Confiture de Vivaneau",
                "Après utilisation, donne un boost de 5% d'attaque et un extra 170 d'attaque à tous les membres de l'équipe pour le prochain combat",
                1, 2, 170, 0.5F, 0);
            ItemList.Add(amuseBouche);

            Item soda = new Item(5, "Soda aux haricots mungo",
                "Après utilisation, donne un boost de 5% d'attaque et un extra 170 d'attaque à tous les membres de l'équipe pour le prochain combat",
                1, 2, 170, 0.5F, 0);
            ItemList.Add(soda);

            return ItemList;
        }

        public List<Chest> createChests()
        {
            Chest chest1 = new Chest(0, ItemList[0], false, new [] { 70, 37 });
            ChestList.Add(chest1);

            Chest chest2 = new Chest(1, ItemList[1], false, new[] { 110, 30 });
            ChestList.Add(chest2);

            Chest chest3 = new Chest(2, ItemList[2], false, new[] { 80, 15 });
            ChestList.Add(chest3);

            Chest chest4 = new Chest(3, ItemList[3], false, new[] { 150, 22 });
            ChestList.Add(chest4);

            Chest chest5 = new Chest(4, ItemList[4], false, new[] { 161, 5 });
            ChestList.Add(chest5);

            Chest chest6 = new Chest(5, ItemList[5], false, new[] { 169, 38 });
            ChestList.Add(chest6);

            return ChestList;
        }

        public List<NPC> createNPCs()
        {
            string wDialog1 = "Bienvenue sur Jarvilo-VI";
            string wDialog2 = "Cette planète a été ravagée par le gel éternel";
            string wDialog3 = "Mais il reste un espoir pour le peuple de cette planète";
            string wDialog4 = "La gardienne suprême, Cocolia, est à l'origine du gel éternel";
            string wDialog5 = "Cocolia dirige Belobog, la ville habritant le peuple de Jarvilo-VI";
            string wDialog6 = "Essaye de la raisonner pour mettre un terme à ce désastre";
            List<string> wDialogs = new List<string>() { wDialog1, wDialog2, wDialog3, wDialog4, wDialog5, wDialog6 };

            NPC welt = new NPC(0, "Welt Yang", wDialogs, false);
            NPCList.Add(welt);

            string sDialog1 = "Salut l'ami ! Mon nom est Sampo Koski.";
            string sDialog2 = "Si tu as le cash j'ai le... Tu as pas de cash ?!";
            List<string> sDialogs = new List<string>() { sDialog1, sDialog2 };

            NPC sampo = new NPC(1, "Sampo", sDialogs, false);
            NPCList.Add(sampo);

            string ccDialog = "Tu es trop faible pour oser me parler...";
            List<string> ccDialogs = new List<string>() { ccDialog };

            NPC cocoliaBully = new NPC(2, "Cocolia", ccDialogs, false);
            NPCList.Add(cocoliaBully);

            string cDialog1 = "Qui es-tu ?";
            string cDialog2 = "Tu n'as rien à dire ?";
            string cDialog3 = "Tu ne viens pas de ce monde, tu ne peux pas comprendre se qui se passe ici";
            string cDialog4 = "Le gel éternel est une fatalité, rien ne peux l'arrêter";
            string cDialog5 = "Maintenant disparait !";
            List<string> cDialogs = new List<string>() { cDialog1, cDialog2, cDialog3, cDialog4, cDialog5 };

            NPC cocolia = new NPC(3, "Cocolia", cDialogs, true);
            NPCList.Add(cocolia);

            return NPCList;
        }
    }
}
