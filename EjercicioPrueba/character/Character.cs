using EjercicioPrueba.effects;
using EjercicioPrueba.equip;
using EjercicioPrueba.interfaces;
using EjercicioPrueba.perks;
using EjercicioPrueba.pets;
using EjercicioPrueba.potions;
using EjercicioPrueba.protections;
using EjercicioPrueba.weapons;

namespace EjercicioPrueba.character;

public class Character
{
    
    public string Name { get; }
    public Perks Perks { get; }
    public Equip Equip { get; }
    public Pet? Pet { get; set; }
    public List<ITem> Inventory { get; }
    public List<Potion> Potions { get; }
    
    public Weapon? WeaponEquip { get; set; }
    public Protection? ProtectionEquip { get; set; }
    

    public Character(string name, int maxHp, int baseDamage, int baseArmor, List<ITem> inventory)
    {
        Name = name;
        Perks = new Perks(maxHp,baseDamage, baseArmor);
        Equip = new Equip(null, null, null, null, null, null, null);
        Inventory = inventory;
    }
    
    public int Attack()
    {
        var random = new Random();
        var rate = random.NextDouble();
        
        if (WeaponEquip != null && rate < WeaponEquip.CriticalRate) 
        {
            return Perks.BaseDamage + WeaponEquip.CriticalDamage;
        }
        
        return Perks.BaseDamage;
    }
    
    public int Defense()
    {
        return Perks.BaseArmor;
    }

    public void Heal(int heal)
    {
        if (Perks.CurrentHp + heal <= Perks.MaxHp)
        {
            Perks.CurrentHp += heal;
        }
        else
        {
            Perks.CurrentHp = Perks.MaxHp;
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
        if (Perks.CurrentHp - damage >= 0) 
        {
            Perks.CurrentHp -= damage;
        }
             
        else
        {
            Perks.CurrentHp = 0;
        }
        
        return false;
    }

    public void Buff(Effect effect, ITem item)
    {
        if (item is Potion)
        {
            item.Apply(this);
        }
    }
}