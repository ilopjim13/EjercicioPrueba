using EjercicioPrueba.character;

namespace EjercicioPrueba.protections;

public class Boots :Protection
{
    public Boots(string name, int armor, double evasionRate) : base(name, armor, evasionRate)
    {
    }

    protected override void AddEquipment(Character character)
    {
        character.Boots = this;
    }

    protected override void QuitEquipment(Character character)
    {
        character.Boots = null;
    }

    protected override bool CheckEquipament(Character character)
    {
        return character.Boots != null;
    }
}