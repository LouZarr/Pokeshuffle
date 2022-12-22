using System;
using System.Collections.Generic;

namespace Pokeshuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> pokemon = new List<String>()
            {"Togekiss", "Toxapex", "Raichu", "Pikachu","Dragapult", "Salamance", "Bagon" };

            List<String> selectedPokemon = new List<String>();

            //As long as the selected pokemon team is less than 6 it will continue
            while (selectedPokemon.Count < 6)
            {
                //Randomizer set for selecting pokemon
                Random rnd = new Random();
                int index = rnd.Next(pokemon.Count);

                //Checks with a method to see if pokemon exists in the team, if true, will not add the pokemon
                if(!PokemonExists(selectedPokemon, pokemon[index]))
                {
                    selectedPokemon.Add(pokemon[index]);
                }

            }

            //Write out the selected team in the console
            foreach(var poke in selectedPokemon)
            {
                Console.WriteLine(poke);
            }

        }

        public static bool PokemonExists(List<String>selectedPokemon, String pokemon) {

            foreach(string poke in selectedPokemon)
            {
                if (poke == pokemon)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
