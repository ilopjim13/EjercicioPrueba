namespace EjercicioPrueba;

public abstract class Protection: Item
{
    
    public string Name { get; set; }
    public int Armor { get; set; }

    public Protection(string name, int armor)
    {
        Name = name;
        Armor = armor;
    }
    
    public void Apply(Character character)
    {
        
    }
}

