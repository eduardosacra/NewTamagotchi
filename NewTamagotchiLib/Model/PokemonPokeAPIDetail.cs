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
    }
}
