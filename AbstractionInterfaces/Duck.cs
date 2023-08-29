class Duck : Bird, IFly, ISwim
{
    public int AirSpeed { get; set; }
    public int Speed { get; set; }
    
    public Duck(string name)
    {
        Name = name;
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} soars into the sky at a rate of {AirSpeed} mph");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} swims away at {Speed} mph");
       
    }
}