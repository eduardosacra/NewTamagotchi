using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTamagotchiLib.Model
{
    public class PokemonPokeAPIDetail
    {
        public List<Abilidades> abilities { get; set; }
        public int height { get; set; }
        public string name { get; set; }
        public List<Types> types { get; set; }
        public int weight { get; set; }

    }
}
