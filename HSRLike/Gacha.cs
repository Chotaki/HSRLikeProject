using HSRLikeProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSRLike
{
    internal class Gacha
    {
        private static List<Character> _dpsList = new List<Character> { };
        private static List<Character> _supportList = new List<Character> { };
        private static List<Character> _healerList = new List<Character> { };

        public static List<Character> DpsList { get => _dpsList; set => _dpsList = value; }
        public static List<Character> SupportList { get => _supportList; set => _supportList = value; }
        public static List<Character> HealerList { get => _healerList; set => _healerList = value; }

        public static void warp(Initialize init, Player p)
        {
            for (int i = 0; i < init.CharacterList.Count; i++)
            {
                // Fill DPS List
                if (init.CharacterList[i].CharacterType == 0)
                {
                    DpsList.Add(init.CharacterList[i]);
                }
                // Fill Healer List
                else if (init.CharacterList[i].CharacterType == 1)
                {
                    HealerList.Add(init.CharacterList[i]);
                }
                // Fill Support List
                else if (init.CharacterList[i].CharacterType == 2 || init.CharacterList[i].CharacterType == 3)
                {
                    SupportList.Add(init.CharacterList[i]);
                }
            }

            Character dps1;
            Character dps2;
            Character healer;
            Character support;

            Random rnd = new Random();

            /*dps1 = DpsList[rnd.Next(DpsList.Count)];*/
            dps1 = DpsList[1];
            DpsList.Remove(dps1);

            /*dps2 = DpsList[rnd.Next(DpsList.Count)];*/
            dps2 = DpsList[2];

            healer = HealerList[rnd.Next(HealerList.Count)];

            support = SupportList[rnd.Next(SupportList.Count)];

            p.PlayerTeam = new[] { dps1, dps2, healer, support };
        }
    }
}
