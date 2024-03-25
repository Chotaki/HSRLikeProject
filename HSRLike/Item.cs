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
        private int _buffQualityLevel;

        public Item(int id, string name, string description, int quantity, int buffType, int buffQuality, int buffQualityLevel)
        {
            _id = id;
            _name = name;
            _description = description;
            _quantity = quantity;
            _buffType = buffType;
            _buffQuality = buffQuality;
            _buffQualityLevel = buffQualityLevel;
        }

        public void use()
        {

        }
    }
}
