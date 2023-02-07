using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2023
{
    public class Pokemon
    {
        public int id { get; set; }

        public string name { get; set; }
        public string type { get; set; }

        public Stats stats {get; set;}

        public Spell spells { get; set;}

   
    }
 
}
