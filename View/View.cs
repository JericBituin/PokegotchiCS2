using Model;
namespace View; // name of the folder it is in

public class PokedexUI{

    // The logic behind the entries
    // public static void - for displaying or no returning a value (return)
    // public static <datatype> - for returning a specific <datatype> value 
    public static void ShowEntries(List<PokedexEntry> pokedexentries){
        int i = 1;
        Console.WriteLine("");
        Console.WriteLine("All the Pokédex Entries");
        Console.WriteLine("");
        pokedexentries.ForEach(entry => {
            Console.WriteLine($"Pokémon No.{i++}"); // the post-increment adds to "i"
            Console.WriteLine($"ID: #{entry.PokemonId}");
            Console.WriteLine($"Name: {entry.PokemonName}");
            Console.WriteLine($"Type: {entry.PokemonType}");
            Console.WriteLine($"Level: {entry.PokemonLevel}");
            Console.WriteLine("");
        });
    }

    public static int IntInput(string message){
        Console.Write(message);
        while(true){
            try{ // tries to run the code block if there will be an input to be returned
                int input = Convert.ToInt32(Console.ReadLine());
                if(input >= 0)
                    return input;
            }
            catch(Exception ex){ // displays a custom error message if try doesn't return an input value
                Console.WriteLine(ex.GetType().Name);
                Console.Write("Try again: ");
            }
        }
    }
    public static int ShowOptions(){
        Console.WriteLine("Welcome to the Pokédex!");
        Console.WriteLine("[1] Add a new Pokémon");
        Console.WriteLine("[2] View all Pokémon");
        Console.WriteLine("[3] Update a Pokémon (Coming Soon!)");
        Console.WriteLine("[4] Delete a Pokémon (Coming Soon!)");
        Console.WriteLine("[5] Exit");
        return IntInput("Choose an option: ");
    }

    public static PokedexEntry AddPokemon(){
        Console.Write("Enter Pokémon ID: ");
        string id = Console.ReadLine();
        Console.Write("Enter Pokémon Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Pokémon Type: ");
        string type = Console.ReadLine();
        int level = IntInput("Enter Pokémon Level: ");
        Console.WriteLine("Pokémon added successfully!");
        
        return new PokedexEntry(id, name, type, level);
    }


}