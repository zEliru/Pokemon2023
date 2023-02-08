using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2023
{
    public class Pokemon
    {
        public int? Id { get; set; }

        public string? Name { get; set; } = string.Empty;
        public string? Type { get; set; } = string.Empty;

        public Stats? PokemonStats { get; set; }

        public Spell? PokemonSpells { get; set;}

   
    }
 
}
