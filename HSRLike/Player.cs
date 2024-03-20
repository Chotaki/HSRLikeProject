using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HsrLikeProject
{
    internal class Player
    {

        class PlayerTeam : Gacha
        {

            void displayTeam(Team)
            {
                foreach (var team in playerTeam)
                {
                    Console.WriteLine(team.name);
                }
            }

        }


        public class ItemList : Item
        {

            var Inventory = new List<int>();

            void AddItem(Item.id)
            {
                Inventory.Add(Item);
            }

            void displayInventory()
            {
                foreach (var item in Inventory)
                {
                    Console.WriteLine(item.name);
                }
            }

        }


        public bool interact()
        {
            if (NPC)
            {
                if (NPC.boss == True)
                {
                    starFight();
                }

                startDialogue();
            }

            if (Chest)
            {
                open();
            }

            return true;
        }

        bool inFight()
        {

        }

    }



}
