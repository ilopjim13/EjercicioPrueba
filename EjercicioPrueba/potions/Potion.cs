using EjercicioPrueba.character;
using EjercicioPrueba.effects;
using EjercicioPrueba.interfaces;

namespace EjercicioPrueba.potions;

public abstract class Potion :ITem
{
    public Effect Effect { get; set; }

    protected Potion(Effect effect)
    {
        Effect = effect;
    }

    public abstract void UsePotion(Character character);

    public void Apply(Character character)
    {
        UsePotion(character);
    }
}