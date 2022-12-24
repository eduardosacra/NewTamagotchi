using NewTamagotchiLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Text.Json;
using System.Text.Json.Serialization;

namespace NewTamagotchiLib.Service
{
    public class PokemonServiceAPI : IPokemonService
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public async Task<CatalogoPokeAPI> ConsultarCatalogo()
        {
            var resultado = await httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon/");
            if (resultado.StatusCode != System.Net.HttpStatusCode.OK)
                throw new Exception($"{resultado.StatusCode}--{resultado.RequestMessage}");

            var retorno = JsonSerializer.Deserialize<CatalogoPokeAPI>(resultado.Content.ReadAsStringAsync().Result);

            return retorno;

    }

        public Task<PokemonPokeAPIDetail> ConsultarPokemon(PokemonPokeAPI pokemon)
        {
            throw new NotImplementedException();
        }
    }
}
