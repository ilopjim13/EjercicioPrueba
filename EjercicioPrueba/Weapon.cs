namespace EjercicioPrueba;

public abstract class Weapon: ITem
{

    public string Name { get; set; }
    
    public int Damage { get; set; }
    
    public double CriticalRate { get; set; }
    
    public int CriticalDamage { get; set; }

    protected Weapon(string name, int damage, double criticalRate, int criticalDamage)
    {
        Name = name;
        Damage = damage;
        CriticalRate = criticalRate;
        CriticalDamage = criticalDamage;
    }
    
    public void Apply(Character character)
    {
        if (character.Inventory.Contains(this))
        {
            Console.WriteLine("This weapon is already in your inventory!");
        }
        else
        {
            character.Inventory.Add(this);
        }
        
    }

    public void Equip(Character character)
    {
        if (character.WeaponEquip != null)
        {
            if (character.WeaponEquip.Damage < Damage)
            {
                character.WeaponEquip.Unequip(character);
                character.WeaponEquip = this;
                Console.WriteLine($"{Name} is now equipped.");
                character.BaseDamage += Damage;
            }
            else
            {
                Console.WriteLine($"{character.Name} is equipping with {character.WeaponEquip.Name}");
            }
        }
        else
        {
            character.WeaponEquip = this;
            Console.WriteLine($"{Name} is now equipped.");
            character.BaseDamage += Damage;
        }
    }

    public void Unequip(Character character)
    {
        if (character.WeaponEquip != null)
        {
            character.WeaponEquip = null;
            character.BaseDamage -= Damage;
            Console.WriteLine($"{Name} is now unequipped.");
        }
        else
        {
            Console.WriteLine($"{character.Name} does not have a weapon equipped");
        }
    }
    
    
}