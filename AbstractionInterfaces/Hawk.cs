class Hawk : Bird, IFly
{
    public int AirSpeed { get; set; }

    public Hawk(string name)
    {
        Name = name;
    }


    public void Fly()
    {
        Console.WriteLine($"{Name} soars into the sky at a rate of {AirSpeed} mph");
        
    }
}