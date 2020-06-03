using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pokemon_Client
{
    class Program
    {
        private static async Task<Pokemon> AccessPokemon(string name)
        {
            try
            {
                var client = new HttpClient();
                var responseAsStream = await client.GetStreamAsync($"https://pokeapi.co/api/v2/pokemon/{name.ToLower()}");
                var result = await JsonSerializer.DeserializeAsync<Pokemon>(responseAsStream);
                return result;
            }
            catch (HttpRequestException)
            {
                return null;
            }
        }

        private static async Task<Type> AccessType(string name)
        {
            try
            {
                var client = new HttpClient();
                var responseAsStream = await client.GetStreamAsync($"https://pokeapi.co/api/v2/type/{name.ToLower()}");
                var result = await JsonSerializer.DeserializeAsync<Type>(responseAsStream);

                return result;
            }
            catch (HttpRequestException)
            {
                return null;
            }
        }

        static async Task Main(string[] args)
        {
            bool pokedexOpen = true;

            while (pokedexOpen)
            {
                Console.Clear();
                Console.WriteLine($"-----------------");
                Console.WriteLine($"Pokedex 1.0 ver.K");
                Console.WriteLine($"-----------------");

                Console.WriteLine($"P - Pokemon Information | T - Type Advantages | Q - Quit");
                var userInput = Console.ReadKey().KeyChar;

                if (userInput == 'p')
                {
                    Console.Write($"Give me a name of a Pokemon: ");
                    var pokemonInput = Console.ReadLine();

                    var pokemonSelected = await AccessPokemon(pokemonInput);

                    if (pokemonSelected != null)
                    {
                        Console.WriteLine($"Pokemon: {pokemonSelected.Name}, height: {pokemonSelected.Height}ft, weight: {pokemonSelected.Weight}lbs ");

                        Console.WriteLine($"Press any key to continue...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine($"That Pokemon doesn't exist...");
                        Console.WriteLine($"\nPress any key to continue...");
                        Console.ReadKey();
                    }
                }

                if (userInput == 't')
                {
                    Console.Write($"Give me type: ");
                    var typeInput = Console.ReadLine();
                    var typeSelected = await AccessType(typeInput);

                    if (typeSelected != null)
                    {
                        Console.WriteLine($"\n{typeSelected.Name} is super effective against");
                        Console.WriteLine($"--------------------------------");
                        foreach (var type in typeSelected.DamageRelations.DoubleDamageTo)
                        {
                            Console.WriteLine(type.Name);
                        }

                        Console.WriteLine($"\n{typeSelected.Name} has no effect by");
                        Console.WriteLine($"--------------------------------");
                        foreach (var type in typeSelected.DamageRelations.NoDamageFrom)
                        {
                            Console.WriteLine(type.Name);
                        }

                        Console.WriteLine($"\n{typeSelected.Name} is weak against:");
                        Console.WriteLine($"--------------------------------");
                        foreach (var type in typeSelected.DamageRelations.DoubleDamageFrom)
                        {
                            Console.WriteLine(type.Name);
                        }

                        Console.WriteLine($"\n{typeSelected.Name} has no effect on");
                        Console.WriteLine($"--------------------------------");
                        foreach (var type in typeSelected.DamageRelations.NoDamageTo)
                        {
                            Console.WriteLine(type.Name);
                        }

                        Console.WriteLine($"\nPress any key to continue...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine($"That type doesn't exist...");
                        Console.WriteLine($"\nPress any key to continue...");
                        Console.ReadKey();
                    }
                }

                if (userInput == 'q')
                {
                    Console.WriteLine($"\nBye bye!");
                    pokedexOpen = false;
                }
            }
        }
    }
}
