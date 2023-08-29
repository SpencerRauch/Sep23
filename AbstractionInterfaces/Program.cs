// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Bird bird = new(); cannot instatiate abstract classes
Hawk redtail = new("Red tail hawk");
Ostrich ostrich = new("Ostrich");
Duck duck = new("Daffy");

List<Bird> AllMyBirds = new(){redtail, ostrich,duck};

foreach (Bird birb in AllMyBirds)
{
    if(birb is IFly f)
    {
        f.Fly();
    }
    if(birb is IRun r){
        r.Run();
    }
    if(birb is ISwim s){
        s.Swim();
    }
}