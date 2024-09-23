namespace EjercicioPrueba;

public abstract class Protection: ITem
{
    
    public string Name { get; set; }
    public int Armor { get; set; }
    public double EvasionRate { get; set; }

    protected Protection(string name, int armor, double evasionRate)
    {
        Name = name;
        Armor = armor;
        EvasionRate = evasionRate;
    }
    
    public void Apply(Character character)
    {
        if (character.Inventory.Contains(this))
        {
            Console.WriteLine("This protection is already in your inventory!");
        }
        else
        {
            character.Inventory.Add(this);
        }
    }

    public void Equip(Character character)
    {
        if (character.ProtectionEquip != null)
        {
            if (character.ProtectionEquip.Armor < Armor)
            {
                character.ProtectionEquip.Unequip(character);
                character.ProtectionEquip = this;
                Console.WriteLine($"{Name} is now equipped.");
                character.BaseArmor += Armor;
            }
            else
            {
                Console.WriteLine($"{character.Name} is equipping with {character.ProtectionEquip.Name}");
            }
        }
        else
        {
            character.ProtectionEquip = this;
            Console.WriteLine($"{Name} is now equipped.");
            character.BaseArmor += Armor;
        }
    }
    
    public void Unequip(Character character)
    {
        if (character.ProtectionEquip != null)
        {
            character.ProtectionEquip = null;
            character.BaseArmor -= Armor;
            Console.WriteLine($"{Name} is now unequipped.");
        }
        else
        {
            Console.WriteLine($"{character.Name} does not have armor equipped");
        }
    }
    
}

