namespace Pokemon;
/*
    CONSIGNES
    1. Déclarer un tableau contenant les six Pokémon suivants :
       - Pikachu
       - Dracaufeu
       - Tortank
       - Florizarre
       - Ectoplasma
       - Ronflex
   2. Utiliser une boucle for pour parcourir le tableau.
   3. Afficher chaque Pokémon avec sa position dans l'équipe.
   4. Afficher le nombre total de Pokémon.
*/
class Program
{
    static void Main(string[] args)
    {
        string[] pokemon = ["Pikachu","Dracaufeu","Tortank","Florizarre","Ectoplasma","Ronflex"];
        foreach (string pokemonname in pokemon)
        {   
            System.Console.Write(System.Array.IndexOf(pokemon, pokemonname) + 1);    
            System.Console.Write(" ");
            System.Console.WriteLine(pokemonname);
        }
        System.Console.WriteLine(pokemon.Length);
    }
}