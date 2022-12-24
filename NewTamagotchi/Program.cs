// See https://aka.ms/new-console-template for more information

using NewTamagotchiLib.Model;
using NewTamagotchiLib.Service;
using System.Linq;

string opcaoMenu = "";
PokemonPokeAPI monstroSelecionado = new PokemonPokeAPI();
bool pokemonFoiSelecionado = false;
int pokemonEscolhidoMenu;
IPokemonService pokeService = new PokemonServiceAPI();


Console.WriteLine("Start - precione Enter");
opcaoMenu = Console.ReadLine();

var monstros = await pokeService.ConsultarCatalogo();

Console.WriteLine("Escolha seu monstrinho");


Console.WriteLine();
Console.WriteLine();


while (!pokemonFoiSelecionado) 
{
    pokemonEscolhidoMenu = 0;
    int contador = 0;
    foreach (var monstro in monstros.results.ToList())
    {
        Console.WriteLine("{0} - {1}", contador++, monstro.name);
    }

    opcaoMenu = Console.ReadLine();
    if (opcaoMenu.Length > 0 && int.TryParse(opcaoMenu, out pokemonEscolhidoMenu))
        monstroSelecionado = pokemonEscolhidoMenu < contador ? monstros.results[pokemonEscolhidoMenu] : null;

    if (monstroSelecionado == null)
    {
        Console.WriteLine();
        Console.WriteLine("Escolha uma opcao valida");
        Console.WriteLine();

    }
    else
        pokemonFoiSelecionado = true;

    Console.WriteLine();

} 

Console.WriteLine($"Monstro Selecionado foi o {monstroSelecionado.name}");