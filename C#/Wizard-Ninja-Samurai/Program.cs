class Program 
{

    static void Main(string[] args)
    {
        Samurai samurai = new Samurai ("Jack", 5 ,15 ,5);
        Human ninja = new Human ("jin" , 5 , 20 , 5 , 50);
        Wizard wizard = new Wizard ("merlin" , 5 , 25);
        Ninja ninja2 = new Ninja ("john" , 5 , 10 , 50);
        wizard.Heal(wizard);
        Console.WriteLine(wizard.Health);
        ninja2.Attack(ninja);

        ninja2.Steal(samurai);
        samurai.Attack(ninja2);
        samurai.Meditate();
    }
}