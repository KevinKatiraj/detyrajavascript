class Buffet
{
    public List<Food> Menu;
     
    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Exam", 1000, false, false),
            new Food("Pica", 1000, false, false),
            new Food("Sushi", 1000, true, false),
            new Food("Torta", 1000, false, true),
            new Food("Gjelle", 1000, false, false),
            new Food("Pule", 1000, true, false),
            new Food("Pilaf", 1000, false, false),
        };
    }
     
    public Food Serve()
    {
        Random rnd = new Random();
        Food Albanian = Menu[rnd.Next(Menu.Count)];
        Console.WriteLine(Albanian);
        return Albanian;

    }
}
