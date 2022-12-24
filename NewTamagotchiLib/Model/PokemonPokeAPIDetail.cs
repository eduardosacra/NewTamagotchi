using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTamagotchiLib.Model
{
    public class PokemonPokeAPIDetail : PokemonPokeAPI
    {
        public IEnumerable<Ability> abilities;
        public int height { get; set; }
        public string name { get; set; }
        public IEnumerable<Types> types { get; set; }
        public int weight { get; set; }

    }
}
