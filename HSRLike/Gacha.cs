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

        public static void warp(Player p)
        {
            for (int i = 0; i < p.CharacterList.Count; i++)
            {
                // Fill DPS List
                if (p.CharacterList[i].CharacterType == 0)
                {
                    DpsList.Add(p.CharacterList[i]);
                }
                // Fill Healer List
                else if (p.CharacterList[i].CharacterType == 1)
                {
                    HealerList.Add(p.CharacterList[i]);
                }
                // Fill Support List
                else if (p.CharacterList[i].CharacterType == 2 || p.CharacterList[i].CharacterType == 3)
                {
                    SupportList.Add(p.CharacterList[i]);
                }
            }

            Character dps1;
            Character dps2;
            Character healer;
            Character support;

            Random rnd = new Random();

            dps1 = DpsList[rnd.Next(DpsList.Count)];
            DpsList.Remove(dps1);

            dps2 = DpsList[rnd.Next(DpsList.Count)];

            healer = HealerList[rnd.Next(HealerList.Count)];

            support = SupportList[rnd.Next(SupportList.Count)];

            p.PlayerTeam = new[] { dps1, dps2, healer, support };
        }
    }
}
