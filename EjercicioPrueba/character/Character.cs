using EjercicioPrueba.interfaces;
using EjercicioPrueba.pets;
using EjercicioPrueba.protections;
using EjercicioPrueba.weapons;

namespace EjercicioPrueba.character;

public class Character
{
    
    public string Name { get; }
    private int MaxHp { get; }
    public int CurrentHp { get; private set; }
    public int BaseDamage { get; set; }
    public double Evasion { get; set; }
    
    public Weapon? WeaponEquip { get; set; }
    public ITem? HandRight { get; set; }
    public ITem? HandLeft { get; set; }
    
    
    public Protection? ProtectionEquip { get; set; }
    public Protection? Helmet { get; set; }
    public Protection? BodyArmor { get; set; }
    public Protection? Gauntlets { get; set; }
    public Protection? Pants { get; set; }
    public Protection? Boots { get; set; }
    
    public int BaseArmor { get; set; }
    public Pet? Pet { get; set; }
    public List<ITem> Inventory { get; }

    public Character(string name, int maxHp, int baseDamage, int baseArmor, List<ITem> inventory)
    {
        Name = name;
        MaxHp = maxHp;
        CurrentHp = MaxHp;
        BaseDamage = baseDamage;
        BaseArmor = baseArmor;
        Inventory = inventory;
    }
    
    public int Attack()
    {
        var random = new Random();
        var rate = random.NextDouble();
        
        if (WeaponEquip != null && rate < WeaponEquip.CriticalRate) 
        {
            return BaseDamage + WeaponEquip.CriticalDamage;
        }
        
        return BaseDamage;
    }
    
    public int Defense()
    {
        return BaseArmor;
    }

    public void Heal(int heal)
    {
        if (CurrentHp + heal <= MaxHp)
        {
            CurrentHp += heal;
        }
        else
        {
            CurrentHp = MaxHp;
        }
        
    }

    public bool ReceiveDamage(int damage)
    {
        var random = new Random();
        var rate = random.NextDouble();

        if (ProtectionEquip != null && rate < ProtectionEquip.EvasionRate)
        {
            return true;
        }
        if (CurrentHp - damage >= 0) 
        {
            CurrentHp -= damage;
        }
             
        else
        {
            CurrentHp = 0;
        }
        
        return false;

        
        
    }
}