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
            ChecaStatusRetorno(ref resultado);
            var retorno = JsonSerializer.Deserialize<CatalogoPokeAPI>(resultado.Content.ReadAsStringAsync().Result);

            return retorno;

    }

        public async Task<PokemonPokeAPIDetail> ConsultarPokemon(PokemonPokeAPI pokemon)
        {
            var resultado = await httpClient.GetAsync(pokemon.url);
            ChecaStatusRetorno(ref resultado);
            var retorno = JsonSerializer.Deserialize<PokemonPokeAPIDetail>(resultado.Content.ReadAsStringAsync().Result);

            return retorno;
                
        }

        private void ChecaStatusRetorno(ref HttpResponseMessage resultado)
        {
            if (resultado.StatusCode != System.Net.HttpStatusCode.OK)
                throw new Exception($"{resultado.StatusCode}--{resultado.RequestMessage}");
        }
    }
}
