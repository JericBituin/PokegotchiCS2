using System.Reflection;

namespace Model;

public class PokedexEntry{
    
    public string PokemonId {get; set;}
    public string PokemonName {get; set;} // to get value from Program.cs and then set (output) data to Program.cs
    public string PokemonType {get; set;} 
    public int PokemonLevel {get; set;}

    public PokedexEntry(string id, string name, string type, int level){
        PokemonId = id;
        PokemonName = name; // giving a substitute value
        PokemonType = type; 
        PokemonLevel = level;
    }
}