using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_5_First_Year_Live_Code
{
    public class Character
    {
        protected int hitPoints, damage;
        public Character(int hp, int dmg)
        {
            (hitPoints, damage) = (hp, dmg);
        }
        public Character(int hp)
        {
            (hitPoints, damage) = (hp, 0);
        }
        public int Attack()
        {
            return damage;
        }
        public bool TakeDamage(int dmg)
        {
            hitPoints -= dmg;
            return hitPoints <= 0;
        }
    }
    public class Player : Character
    {
        private string item;
        public Player(int hp, int dmg, string startingItem) : base(hp, dmg)
        {
            item = startingItem;
        }
        public void GiveItem(string newItem)
        {
            if (item=="nothing") item = newItem;
        }
        public string DropItem()
        {
            string thing = item;
            item = "nothing";
            return thing;
        }
    }
}
