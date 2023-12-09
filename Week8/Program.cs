
string[] tvShows = { "Firefly", "Office", "The Last of Us", "Friends", "Twin Peaks", "House", "Stranger Things" };

string[] food = { "sushi", "pizza", "Chinese takeaway", "burger and chips", "chicken wings", "chips", "popcorn" };

string[] drinks = { "mineral water", "Coca-Cola", "apple juice", "milk", "beer" };

//Random rnd = new Random();  

//int randomIndex = rnd.Next(tvShows.Length);
//string randomMovie = tvShows[randomIndex];
//Console.WriteLine(randomMovie);

//randomIndex = rnd.Next(food.Length);
//string randomFood = food[randomIndex];
//Console.WriteLine(randomFood);

//randomIndex = rnd.Next(drinks.Length);
//string randomDrink = drinks[randomIndex];
//Console.WriteLine(randomDrink);

//DRY - Do not Repeat Yourself

string randomMovie = PickRandomFromArray(tvShows);
string randomFood = PickRandomFromArray(food);
string randomDrink = PickRandomFromArray(drinks);

Console.WriteLine($"I recommend you to watch {randomMovie} tonight.");
Console.WriteLine ($"Order some {randomFood} and some {randomDrink}.");


static string PickRandomFromArray(string[] someArray)
{
    Random rnd = new Random();
    
    int randomIndex = rnd.Next(someArray.Length);
    string randomElement = someArray[randomIndex];
    return randomElement;
}