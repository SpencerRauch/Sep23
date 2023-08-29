// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Food Banana = new(true, "banana",40,0.50);

// Console.WriteLine($"Banana {(Banana._Delicious ? "is" :"is not" )} delicious");

// Banana._Calories = -120;

// Console.WriteLine(Banana._Calories);


Fruit Banana = new(true, "banana",40,1.00,false,true,"green");


Banana.PrintInfo();

Food Generic = new();
Generic.PrintInfo();

Food Cake = new("cake",2000,3.99);

Console.WriteLine(Cake._Delicious);


