class Ninja : Human
{
     public Ninja(string name, int str, int intel, int hp) : base (175)
    {
        Name = name;
        Strength = str;
        Intelligence = intel;
        Health = hp;
    }

     public override int Attack(Human target)
    {
        Random rnd = new Random();
        int rand = rnd.Next(1,6);
        if(rand == 1)
        {
            target.Health -= 10;      
        }

        int dmg = Dexterity * 5;
        target.Health -= dmg;
        Console.WriteLine(target.Health);
        return target.Health;
    }

     public int Steal( Human target)
    {
       target.Health -= 5 ;
       Health += 5 ;
       Console.WriteLine("Ninja stole from samurai 5 point and now its health is " + Health + "points");
       return target.Health;
    }
}