// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<VideoGame> Games = new List<VideoGame> {
    new VideoGame("Apex Legends", "Riot", "E", 0, "Xbox"),
    new VideoGame("The Last of Us", "Naughty Dog", "M", 39.99, "PlayStation"),
    new VideoGame("Untitled Goose Game", "House House", "E", 29.99, "PC"),
    new VideoGame("Super Mario Bros.", "Nintendo", "E", 49.99, "SNES"),
    new VideoGame("Elden Ring", "FromSoftware", "M", 59.99, "PC"),
    new VideoGame("World of Warcraft", "Blizzard", "E", 49.99, "PC"),
    new VideoGame("Overwatch 2", "Blizzard", "T", 0, "PC"),
    new VideoGame {Title="Kirby's Air Ride",Studio="Nintendo",Rating="E",Price=20.00,Platform="Gamecube"},
};

foreach (VideoGame videoGame in Games)
{
    Console.WriteLine(videoGame);
    
}