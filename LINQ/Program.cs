// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<VideoGame> Games = new List<VideoGame> {
    new VideoGame("Apex Legends", "Riot", "E", 0, "Xbox, PC"),
    new VideoGame("The Last of Us", "Naughty Dog", "M", 39.99, "PlayStation"),
    new VideoGame("Untitled Goose Game", "House House", "E", 29.99, "PC"),
    new VideoGame("Super Mario Bros.", "Nintendo", "E", 49.99, "SNES"),
    new VideoGame("Elden Ring", "FromSoftware", "M", 59.99, "PC"),
    new VideoGame("World of Warcraft", "Blizzard", "E", 49.99, "PC"),
    new VideoGame("Overwatch 2", "Blizzard", "T", 0, "PC"),
    new VideoGame { Title = "The Legend of Zelda: Breath of the Wild", Studio = "Nintendo", Rating = "E10+", Price = 59.99, Platform = "Nintendo Switch"},
    new VideoGame { Title = "MonsterHunterWorld", Studio = "Capcom", Rating = "M", Price = 40.99, Platform = "PlayStation 4" },
    new VideoGame { Title = "Grand Theft Auto V", Studio = "Rockstar Games", Rating = "M", Price = 29.99, Platform = "PlayStation 4" },
    new VideoGame { Title = "Minecraft", Studio = "Mojang", Rating = "E10+", Price = 26.95, Platform = "PC" },
    new VideoGame { Title = "Fortnite", Studio = "Epic Games", Rating = "T", Price = 0.00, Platform = "Various" },
    new VideoGame { Title = "Red Dead Redemption 2", Studio = "Rockstar Games", Rating = "M", Price = 39.99, Platform = "Xbox One" },
    new VideoGame { Title = "Super Mario Odyssey", Studio = "Nintendo", Rating = "E10+", Price = 49.99, Platform = "Nintendo Switch"},
    new VideoGame  { Title="Kirby's Air Ride",Studio="Nintendo",Rating="E",Price=20.00,Platform="Gamecube"},
};

foreach (VideoGame videoGame in Games)
{
    Console.WriteLine(videoGame);

}


