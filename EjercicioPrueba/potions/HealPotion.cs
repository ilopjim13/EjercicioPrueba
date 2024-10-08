using EjercicioPrueba.character;
using EjercicioPrueba.effects;

namespace EjercicioPrueba.potions;

public class HealPotion : Potion
{
    public int Heal { get; set; }

    public HealPotion(Effect effect, int heal) : base(effect)
    {
        Heal = heal;
    }

    public override void UsePotion(Character character)
    {
        character.Heal(Heal);
    }
}