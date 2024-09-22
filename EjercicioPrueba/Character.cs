namespace EjercicioPrueba;

public class Character
{
    
    public string Name { get; set; }
    public int MaxHitPoints { get; set; }
    public int CurrentHitPoints { get; set; }
    public int BaseDamage { get; set; }
    public int BaseArmor { get; set; }
    public List<Item> Inventory { get; set; }

    public Character(string name, int maxHitPoints, int baseDamage, int baseArmor, List<Item> inventory)
    {
        Name = name;
        MaxHitPoints = maxHitPoints;
        CurrentHitPoints = maxHitPoints; // Inicializa los puntos de vida actuales al máximo
        BaseDamage = baseDamage;
        BaseArmor = baseArmor;
        Inventory = inventory;
    }
    
    public int Attack()
    {
        BaseDamage += BaseDamage;
        return BaseDamage;
    }
    
    public int Defense()
    {
        return BaseDamage;
    }

    public void Heal(int heal)
    {
        
    }

    public void ReceiveDamage(int damage)
    {
        
    }
}