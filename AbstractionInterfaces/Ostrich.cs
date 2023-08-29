class Ostrich : Bird, IRun
{
    public int LandSpeed {get; set;}
    
    public Ostrich(string name)
    {
        Name = name;
    }

    public void Run()
    {
        Console.WriteLine($"{Name} sprints forward at {LandSpeed} mph");
        
    }


}