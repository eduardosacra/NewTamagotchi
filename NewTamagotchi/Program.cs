// See https://aka.ms/new-console-template for more information

using NewTamagotchiLib.Model;
using NewTamagotchiLib.Service;
using NewTamagotchiLib.View;
using System.Linq;

MenuIterativo menu = new MenuIterativo();


menu.BoasVindas();

menu.ExibirChocando();

menu.ExibirTitulo(" Adotar um Mascote ");
menu.ExibirTitulo();
menu.ExibirTitulo(" menu ");

//string opcaoMenu = "";
//PokemonPokeAPI monstroSelecionado = new PokemonPokeAPI();
//bool pokemonFoiSelecionado = false;
//int pokemonEscolhidoMenu;
//IPokemonService pokeService = new PokemonServiceAPI();


//Console.WriteLine("Start - precione Enter");
//opcaoMenu = Console.ReadLine();

//var monstros = await pokeService.ConsultarCatalogo();

//Console.WriteLine("Escolha seu monstrinho");


//Console.WriteLine();
//Console.WriteLine();


//while (!pokemonFoiSelecionado) 
//{
//    pokemonEscolhidoMenu = 0;
//    int contador = 0;
//    foreach (var monstro in monstros.results.ToList())
//    {
//        Console.WriteLine("{0} - {1}", contador++, monstro.name);
//    }

//    opcaoMenu = Console.ReadLine();
//    if (opcaoMenu.Length > 0 && int.TryParse(opcaoMenu, out pokemonEscolhidoMenu))
//        monstroSelecionado = pokemonEscolhidoMenu < contador ? monstros.results[pokemonEscolhidoMenu] : null;

//    if (monstroSelecionado == null)
//    {
//        Console.WriteLine();
//        Console.WriteLine("Escolha uma opcao valida");
//        Console.WriteLine();

//    }
//    else
//        pokemonFoiSelecionado = true;

//    Console.WriteLine();

//} 

//Console.WriteLine($"Monstro Selecionado foi o {monstroSelecionado.name}");

//Console.WriteLine();

//Console.WriteLine("Consultar Detalhes sobre o seu Monstrinho");
//var pokemon = await pokeService.ConsultarPokemon(monstroSelecionado);
//Console.WriteLine("-------------------------------------------");
//Console.WriteLine($"Nome Pokemon: {pokemon.name} - Altura: {pokemon.height} - Peso: {pokemon.weight}");
//Console.WriteLine("Tipo:");
//foreach (var item in pokemon.types)
//{
//    Console.WriteLine($"** {item.type.name}");
//}

//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine($"Habilidades:");
//foreach (var habilidade in pokemon.abilities)
//{
//    Console.WriteLine($"** {habilidade.ability.name}");
//}

//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine("Excelente Escolha!!!");