class Food
{
    //fields
    private bool Delicious;
    public bool _Delicious {get {return Delicious;}}
    string Name;
    private int Calories;
    public int _Calories {get {return Calories;}set {if (value > 0) Calories = value;}}
    private double Price;

    public Food(bool delicious, string name, int calories, double price)
    {
        Delicious = delicious;
        Name = name;
        Calories = calories;
        Price = price;
    }
    public Food(string name, int calories, double price)
    {
        Delicious = true;
        Name = name;
        Calories = calories;
        Price = price;
    }
    public Food(bool delicious, string name, int calories)
    {
        Delicious = delicious;
        Name = name;
        Calories = calories;
        Price = 0.00;
    }

    public Food()
    {
        Delicious = true;
        Name = "Blank Food";
        Calories = 0;
        Price = 0.00;
    }

    //methods - things our class can do!
    public virtual void PrintInfo()
    {
        Console.WriteLine($"{Name} is {Calories} calories and {(Delicious ? "is" :"is not" )} delicious and costs {Price} ");
        
    }


}
