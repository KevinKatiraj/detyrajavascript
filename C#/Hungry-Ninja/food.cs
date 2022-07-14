class Food
{
    public string Name;
    public int Calories;
    public bool IsSpicy; 
    public bool IsSweet; 

    public Food(string emri , int kalori , bool pikante , bool embelsia )
    {
        Name = emri;
        Calories = kalori;
        IsSpicy = pikante;
        IsSweet = embelsia;
        
    }
}