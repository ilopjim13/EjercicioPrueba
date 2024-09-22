namespace EjercicioPrueba;

public abstract class Weapon: Item
{

    public string Name { get; set; }
    
    public int Damage { get; set; }

    protected Weapon(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }
    
    public void Apply(Character character)
    {
        Name = "pepe";
    }
}