using EjercicioPrueba.character;
using EjercicioPrueba.interfaces;

namespace EjercicioPrueba.protections;

public abstract class Protection: IEquippable
{
    
    public string Name { get; set; }
    private int Armor { get; }
    public double EvasionRate { get;}

    protected Protection(string name, int armor, double evasionRate)
    {
        Name = name;
        Armor = armor;
        EvasionRate = evasionRate;
    }
    
    public virtual void Apply(Character character)
    {
        character.Perks.BaseArmor += Armor;
        character.Perks.Evasion += EvasionRate;
    }

    public void UnApply(Character character)
    {
        character.Perks.BaseArmor -= Armor;
        character.Perks.Evasion -= EvasionRate;
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
        if (CheckEquipament(character))
        {
            Console.WriteLine($"{character.Name} is equipping with an item");
        }
        else
        {
            AddEquipment(character);
            Console.WriteLine($"{Name} is now equipped.");
            Apply(character);
        }
    }

    protected abstract void AddEquipment(Character character);
    protected abstract void QuitEquipment(Character character);
    protected abstract bool CheckEquipament(Character character);
    
    public void UnEquip(Character character)
    {
        if (CheckEquipament(character))
        {
            QuitEquipment(character);
            UnEquip(character);
            Console.WriteLine($"{Name} is now unequipped.");
        }
        else
        {
            Console.WriteLine($"{character.Name} does not have armor equipped");
        }
    }
    
}

