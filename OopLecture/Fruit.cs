class Fruit : Food
{
    public bool Ripe;
    public bool HasSeed;
    public string Color;

    public Fruit(bool delicious, string name, int calories, double price, bool ripe, bool hasSeed, string color) 
    : base(delicious,name,calories,price)
    {
        Ripe = ripe;
        HasSeed = hasSeed;
        Color = color;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"This is ripe: {Ripe}");
    }
}