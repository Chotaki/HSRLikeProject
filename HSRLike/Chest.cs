using HSRLike;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HSRLikeProject
{
    public class Chest
    {
        private Item _reward;
        private bool _isOpen;
        private int _id;
        private int[] _position = new int[2];
        public Item Reward { get => _reward; set => _reward = value;  }
        public bool IsOpen { get => _isOpen; set => _isOpen = value; } 
        public int Id { get => _id; set => _id = value; }
        public int[] Position { get => _position; set => _position = value; }

        public Chest(int id, Item reward, bool isOpen, int[] position) {
            Id = id;
            Reward = reward;
            IsOpen = isOpen;
            Position = position;
        }

        public void open(Player p, int detectedChestId)
        {
            p.Inventory.Add(this.Reward);
            this.IsOpen = true;
        }
    }
}
