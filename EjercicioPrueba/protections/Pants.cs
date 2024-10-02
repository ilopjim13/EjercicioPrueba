using EjercicioPrueba.character;

namespace EjercicioPrueba.protections;

public class Pants :Protection
{
    public Pants(string name, int armor, double evasionRate) : base(name, armor, evasionRate)
    {
    }

    protected override void AddEquipment(Character character)
    {
        character.Pants = this;
    }

    protected override void QuitEquipment(Character character)
    {
        character.Pants = null;
    }

    protected override bool CheckEquipament(Character character)
    {
        return character.Pants != null;
    }
}