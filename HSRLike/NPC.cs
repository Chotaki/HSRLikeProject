using HSRLike;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSRLikeProject
{
    internal class NPC
    {
        private int _id;
        private string _name;
        private List<string> _dialogs = new List<string>();
        private bool _isBoss;

        public int ID { get => _id; }
        public string Name { get => _name; }
        public List<string> Dialogs { get => _dialogs; }
        public bool IsBoss { get => _isBoss; }

        public NPC(int id, string name, List<string> dialogs, bool isBoss)
        {
            _id = id;
            _name = name;
            _dialogs = dialogs;
            _isBoss = isBoss;
        }

        public void startDialog(Initialize init, NPC npc, Player p)
        {
            for (int i =  0; i < init.NPCList.Count; i++)
            {
                if (init.NPCList[i].ID == npc.ID)
                {
                    int j = 0;
                    do {
                        Console.WriteLine(init.NPCList[i].Dialogs[j]);
                        ConsoleKeyInfo space = Console.ReadKey(true);
                        if (space.Key == ConsoleKey.Spacebar)
                        {
                            j++;
                            if (init.NPCList[i].IsBoss == true && j == 5)
                            {
                                p.fight(2);
                            }
                        }
                    } while (j != init.NPCList[i].Dialogs.Count);
                }
            }
        }
    }
}
