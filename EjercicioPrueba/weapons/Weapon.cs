using EjercicioPrueba.character;
using EjercicioPrueba.interfaces;

namespace EjercicioPrueba.weapons;

public abstract class Weapon: IEquippable
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
        character.Perks.BaseDamage += Damage;
    }
    
    public void UnApply(Character character)
    {
        character.Perks.BaseDamage -= Damage;
    }
    
    public void AddItem(Character character)
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
                character.WeaponEquip.UnEquip(character);
                character.WeaponEquip = this;
                Console.WriteLine($"{Name} is now equipped.");
                Apply(character);
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
            Apply(character);
        }
    }

    public void UnEquip(Character character)
    {
        if (character.WeaponEquip != null)
        {
            character.WeaponEquip = null;
            UnApply(character);
            Console.WriteLine($"{Name} is now unequipped.");
        }
        else
        {
            Console.WriteLine($"{character.Name} does not have a weapon equipped");
        }
    }
    
    
}