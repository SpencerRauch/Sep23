// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Again!");

// let x = 9
// x = "String"

// datatype VariableName

int num = 9;
// num = "String";
string MyString = "My String";

Console.WriteLine($"My num was {num} my string was {MyString}");

bool IsCool = true;

// arrays
int[] Nums;

int[] Odds = new int[3];

int[] Evens = new int[5]{2,4,6,8,10};

for (int i = 0; i < Evens.Length; i++)
{
    Evens[i] *= 2;
    Console.WriteLine(Evens[i]);

}
for (int i = 0; i < Odds.Length; i++)
{
    // Evens[i] *= 2;
    Console.WriteLine(Odds[i]);

}

// lists

List<string> Desserts = new();
Desserts.Add("ice cream");
Desserts.Add("pie");
Desserts.Add("brownie");

foreach (string s in Desserts)
{
    // s = "Cake"; this causes run time error!
    Console.WriteLine(s);
}


// dictionaries
Dictionary<string,int> PetAges = new();
PetAges.Add("Wiley",4);
PetAges.Add("Rin",6);
PetAges.Add("Koda",4);
PetAges.Add("Arrow",4);

foreach (KeyValuePair<string,int> petAge in PetAges)
{
    Console.WriteLine($"Pet {petAge.Key} is {petAge.Value} years old");
}