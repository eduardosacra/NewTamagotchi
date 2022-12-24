using NewTamagotchiLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTamagotchiLib.Service
{
    public interface IPokemonService
    {
        Task<CatalogoPokeAPI> ConsultarCatalogo();
        Task<PokemonPokeAPIDetail> ConsultarPokemon(PokemonPokeAPI pokemon);
    }
}
