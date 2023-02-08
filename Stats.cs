using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2023
{
    public class Stats
    {

        public int? damage; 
        public int? health; 
        public int? defense;
        public Stats(int dmg, int hp, int def)
        {

            damage = dmg;
            health = hp;
            defense = def;
        

        }
    }
}




