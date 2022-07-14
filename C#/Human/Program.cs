class Human
{
    // Properties for Human
    public string Name{get;set;}
    public int Strength{get;set;}
    public int Intelligence{get;set;}
    public int Dexterity{get;set;}
    public int Health{get;set;}
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
     public Human (string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 43;
            Health = 100;
        }
    // Add a constructor to assign custom values to all fields
     public Human (string name , int strng , int intel, int dex , int hea )
    {
            Name = name;
            Strength = strng;
            Intelligence = intel;
            Dexterity = dex;
            Health = hea;
        
    }
    // Build Attack method
    public int Attack(Human target)
    {
        int dmg = Strength * 5;
        target.Health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        Console.WriteLine($"Current health of {target.Name} is {target.Health}!");

        return target.Health;
    }
}


class Program
{
    public static void Main(string [] args )
    {
        Human Melis = new Human("Melis" , 100 , 200 , 15 , 150);
        Human Albert = new Human("Albert"  , 100 , 200 , 15 , 150);
        Melis.Attack(Albert);
    }
}