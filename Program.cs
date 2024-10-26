// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Model;
using View;
// using Controller;

// the "pokedexEntries" is a local variable\
// List creating arrays
List<PokedexEntry> pokedexEntries = new List<PokedexEntry>(); // Connection to the Model.PokedexEntry
pokedexEntries.Add(new PokedexEntry("0001", "Bulbasaur", "Grass", 10)); // pre-set data to model.cs PokedexEntry
pokedexEntries.Add(new PokedexEntry("0018", "Pidgey", "Normal", 5)); //  "Add" is a function 
pokedexEntries.Add(new PokedexEntry("0249", "Lugia", "Psychic", 100));

int menu_opt;
do{
    Console.WriteLine("");
    menu_opt = PokedexUI.ShowOptions(); // PokedexUI is the public class in view.cs ShowOptions in view.cs
    if(menu_opt == 1){
        pokedexEntries.Add(PokedexUI.AddPokemon());
    }
    else if(menu_opt == 2){
        PokedexUI.ShowEntries(pokedexEntries);
    }
    else if(menu_opt == 3 || menu_opt == 4){
        Console.WriteLine("This feature is coming soon!");
    }
    else if(menu_opt > 5){
        Console.WriteLine("Please choose an option between 1 to 5!");
    }
}while(menu_opt != 5); // && menu_opt <= 5 && menu_opt > 0

Console.WriteLine("Good Bye!");