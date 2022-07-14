class Samurai : Human 
{
     public Samurai(string name, int str, int intel, int dex):base (200)
    {
        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        Health = 200;
    }

    
    public override int Attack(Human target)
    {
        base.Attack(target);
        if (target.Health < 50)
        {
            target.Health = 0;
        }
        Console.WriteLine("health of ninja now is" + target.Health);
        return target.Health;
    }

    
     public void Meditate()
    {
       Health = 200;
       Console.WriteLine("Samurai health after meditate is full" + Health);
    }
}