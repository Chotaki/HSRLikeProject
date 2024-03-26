using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSRLikeProject
{
    internal class Item
    {
        private int _id;
        private string _name;
        private string _description;
        private int _quantity;
        private int _buffType;
        private int _buffQuality;
        private float _buffMultiplier;
        private int _buffQualityLevel;

        public int Id { get => _id; }
        public string Name { get => _name; }
        public string Description { get => _description; }
        public int Quantity { get => _quantity; set => _quantity = value;  }
        public int BuffType { get => _buffType; }
        public int BuffQuality { get => _buffQuality; }
        public float BuffMultiplier { get => _buffMultiplier; }
        public int BuffQualityLevel { get => _buffQualityLevel; }

        public Item(int id, string name, string description, int quantity, int buffType, int buffQuality, float buffMultiplier, int buffQualityLevel)
        {
            _id = id;
            _name = name;
            _description = description;
            _quantity = quantity;
            _buffType = buffType;
            _buffQuality = buffQuality;
            _buffMultiplier = buffMultiplier;
            _buffQualityLevel = buffQualityLevel;
        }

        public void use(Player p)
        {
            if (this.BuffType == 0)
            {
                for (int i = 0;  i < p.PlayerTeam.Length; i++)
                {
                    p.PlayerTeam[i].ATK += this.BuffQuality;
                }
            } else if (this.BuffType == 1)
            {
                for (int i = 0; i < p.PlayerTeam.Length; i++)
                {
                    p.PlayerTeam[i].ATK += (int)Math.Round(p.PlayerTeam[i].ATK * this.BuffMultiplier);
                }
            } else if (this.BuffType == 2)
            {
                for (int i = 0; i < p.PlayerTeam.Length; i++)
                {
                    p.PlayerTeam[i].ATK += (int)Math.Round(p.PlayerTeam[i].ATK * this.BuffMultiplier);
                    p.PlayerTeam[i].ATK += this.BuffQuality;
                }
            }

            this.Quantity -= 1;
        }
    }
}
