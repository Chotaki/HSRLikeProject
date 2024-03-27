using HSRLike;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HSRLikeProject
{
    internal class Chest
    {
        private Item _reward;
        private bool _isOpen;

        public Item Reward { get => _reward; set => _reward = value;  }
        public bool IsOpen { get => _isOpen; set => _isOpen = value; } 

        public Chest(Item reward, bool isOpen) {
            _reward = reward;
            _isOpen = isOpen;
        }

        public void open(Player p)
        {
            p.Inventory.Add(this.Reward);
            IsOpen = true;
        }
    }
}
