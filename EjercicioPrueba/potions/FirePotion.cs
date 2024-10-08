using EjercicioPrueba.character;
using EjercicioPrueba.effects;

namespace EjercicioPrueba.potions;

public class FirePotion : Potion
{
    public int Fire { get; }
    public int Duration { get; set; }
    private int DurationMax { get; }
    public bool Used { get; set; }

    public FirePotion(Effect effect, int fire, int duration) : base(effect)
    {
        Fire = fire;
        DurationMax = duration;
        Duration = DurationMax;
    }
    

    public override void UsePotion(Character character)
    {
        if (Duration > 0)
        {
            character.Perks.BaseDamage += Fire;
            Console.WriteLine($"The enemy has burned! takes {Fire} damage");
            Duration--;
        }
        else Disable(character);

    }

    public void Disable(Character character)
    {
        Duration = DurationMax;
    }
}